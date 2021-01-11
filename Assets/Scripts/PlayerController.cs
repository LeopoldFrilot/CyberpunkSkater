using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    PlayerControls inputs;

    [Header("Player attributes")]
    public float vertSpeed = 10f;
    public float horizSpeed = 2f;
    public float teleportDistance = 30f;
    public float invincibilityTime = 3f;
    public float maxFlyTime = 5f;

    [Header("Lane logic")]
    public float maxHeight = 450f;
    public int laneNum = 3;
    public float minHeight = -450f;
    public float laneWidth;
    public int curLane;
    public float perspectiveScale = .1f;
    public float minHorizPos = -9f;

    //External Connections
    public Accelerator AC;
    public GameManager GM;

    private float _vertical, _horizontal, _teleport, _pause;
    private bool hasTeleported = false;
    private bool isMovingLanes = false;
    private bool isPaused = false;
    private bool pausePressed = false;
    private Vector3 defaultScale;
    private Animator animator;
    private float flightTime = 0;

    public void Awake()
    {
        inputs = new PlayerControls();
        inputs.PCMap.Vertical.performed += context => _vertical = context.ReadValue<float>();
        inputs.PCMap.Vertical.canceled += context => _vertical = 0f;
        inputs.PCMap.Horizontal.performed += context => _horizontal = context.ReadValue<float>();
        inputs.PCMap.Horizontal.canceled += context => _horizontal = 0f;
        inputs.PCMap.Teleport.performed += context => _teleport = context.ReadValue<float>();
        inputs.PCMap.Teleport.canceled += context => _teleport = 0f;
        inputs.PCMap.Pause.performed += context => _pause = context.ReadValue<float>();
        inputs.PCMap.Pause.canceled += context => _pause = 0f;
    }
    // Start is called before the first frame update
    void Start()
    {
        AC = FindObjectOfType<Accelerator>();
        GM = FindObjectOfType<GameManager>();
        laneWidth = (maxHeight - minHeight) / (laneNum - 1);
        transform.position = new Vector3(-7.4f, minHeight + laneWidth);
        curLane = 2;
        defaultScale = transform.localScale;
        UpdateScale();
        UpdateLayer(curLane);
        animator = GetComponent<Animator>();
    }


    // Update is called once per frame
    void Update() 
    {
        if(flightTime > 0)
        {
            flightTime -= Time.deltaTime;
            if(flightTime <= 0)
            {
                EndFlight();
            }
        }
        float curHorizSpeed = horizSpeed * Mathf.Clamp(1 - AC.speed, 0, 1);
        float yStore = 0;
        float xStore = 0;
        if(_pause == 1 && !pausePressed)
        {
            pausePressed = true;
            if (isPaused)
            {
                GM.ResumeGame();
                isPaused = false;
            }
            else
            {
                GM.PauseGame();
                isPaused = true;
            }
        }
        else if(_pause == 0 && pausePressed)
        {
            pausePressed = false;
        }
        else if(!isPaused)
        {
            if (_vertical > 0 && !isMovingLanes)
            {
                yStore = MoveUpLane();
                isMovingLanes = true;
            }
            else if (_vertical < 0 && !isMovingLanes)
            {
                yStore = MoveDownLane();
                isMovingLanes = true;
            }
            else if (_vertical == 0)
            {
                isMovingLanes = false;
            }
            if (_horizontal != 0)
            {
                xStore += _horizontal * curHorizSpeed * Time.deltaTime;
            }
            animator.SetFloat("Speed", _horizontal);
            if (_teleport != 0 && !hasTeleported)
            {
                xStore += teleportDistance;
                hasTeleported = true;
            }
            else if (_teleport == 0)
            {
                if (hasTeleported) xStore -= teleportDistance; // Probably won't keep this
                hasTeleported = false;
            }
        }
        
        transform.position += new Vector3(xStore, yStore, 0);
        if(transform.position.x < minHorizPos) // Setting boundaries
        {
            transform.position = new Vector3(minHorizPos, transform.position.y);
        }
    }
    public float MoveUpLane()
    {
        if (curLane == 1)
        {
            return 0;
        }
        curLane--;
        UpdateScale();
        UpdateLayer(curLane);
        return laneWidth;
    }
    public float MoveDownLane()
    {
        if (curLane == laneNum)
        {
            return 0;
        }
        curLane++;
        UpdateScale();
        UpdateLayer(curLane);
        return -laneWidth;
    }
    private void UpdateScale()
    {
        transform.localScale = new Vector3(defaultScale.x + curLane * perspectiveScale, defaultScale.y + curLane * perspectiveScale);
    }
    public bool TakeDamage(int lane)
    {
        if(curLane == lane && !GetComponent<InvincibilityFlash>().IsInvincible())
        {
            Debug.Log("TOOK DAMAGE");
            AC.speed = AC.speed * 2f / 3f;
            GetComponent<InvincibilityFlash>().StartFlash(invincibilityTime);
            FindObjectOfType<LifeManager>().DecrimentLives();
            animator.SetTrigger("Damage");
            return true;
        }
        return false;
    }
    private void UpdateLayer(int num)
    {
        string name = "Lane" + num + " Background";
        transform.GetComponent<SpriteRenderer>().sortingLayerName = name;
        gameObject.layer = 7 + num;
        gameObject.transform.GetChild(0).gameObject.layer = 7 + num;
    }
    public bool CollectFuel(GameObject fuel, int lane)
    {
        if(lane == curLane)
        {
            Destroy(fuel);
            return true;
        }
        return false;
    }
    public bool CollectStar(int lane)
    {
        if (lane == curLane)
        {
            return true;
        }
        return false;
    }
    public void StartFlight()
    {
        transform.GetChild(0).GetComponent<Collider2D>().enabled = false;
        flightTime = maxFlyTime;
        animator.SetBool("Flying", true);
    }
    public void EndFlight()
    {
        transform.GetChild(0).GetComponent<Collider2D>().enabled = true;
        animator.SetBool("Flying", false);
        GetComponent<InvincibilityFlash>().StartFlash(invincibilityTime);
    }
    public void OnEnable()
    {
        inputs.Enable();
    }
    public void OnDisable()
    {
        inputs.Disable();
    }
}
