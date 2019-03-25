using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RobotScript : MonoBehaviour
{
    public Vector3 startpoint;
    public Vector3 endpoint;
    public float aggroRange = 5.0f;
    public bool turning = false;
    public float movespeed = 10.0f;
    public float turnspeed = 2.0f;
    public Vector3 player;
    //public GameObject player;

    enum EnemyState
    {
        Patrolling, Chasing, Returning
    };

    private EnemyState state;
    // Start is called before the first frame update
    void Start()
    {
        startpoint = transform.position;
        endpoint = startpoint + new Vector3(0, 0, 30);
        state = EnemyState.Patrolling;
        player = new Vector3(5, 1.5f, -5);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        switch (state)
        {
            case EnemyState.Patrolling:
                Patrol();
                break;
            case EnemyState.Chasing:
                Chase();
                break;
            case EnemyState.Returning:
                Return();
                return;
        }
    }

    void Update()
    {
        //DEBUG
        if (Input.GetButton("Jump"))
            Disable();

        if (Input.GetButton("Fire1"))
            Reset();

        if (Input.GetButton("Chase"))
            state = EnemyState.Chasing;

        if (Input.GetButton("Return"))
            state = EnemyState.Returning;
        //DEBUG
    }
    

    public void Disable()
    {
        //disable robot
        Destroy(gameObject);
    }

    protected void Chase()
    {
        transform.position = Vector3.MoveTowards(transform.position, player, movespeed * Time.deltaTime);
        if (Vector3.Distance(transform.position, player) > aggroRange)
        //    transform.position = Vector3.MoveTowards(transform.position, player.transform.position, movespeed * Time.deltaTime);
        //if (Vector3.Distance(transform.position, player.transform.position) > aggroRange)
            state = EnemyState.Returning;
    }

    protected void Return()
    {
        if (Vector3.Distance(transform.position, startpoint) > Vector3.Distance(transform.position, endpoint))
            transform.position = Vector3.MoveTowards(transform.position, endpoint, movespeed * Time.deltaTime);
        else transform.position = Vector3.MoveTowards(transform.position, startpoint, movespeed * Time.deltaTime);

        if (transform.position == startpoint || transform.position == endpoint)
            state = EnemyState.Patrolling;
    }

    protected void Patrol()
    {
        if (state == EnemyState.Patrolling)
        {
            if (turning)
            {
                if (transform.position.z >= endpoint.z)
                    transform.LookAt(startpoint);
                else transform.LookAt(endpoint);
                turning = false;
            }
            else
            {
                transform.Translate(Vector3.forward * movespeed * Time.deltaTime);
                if (transform.position.z >= endpoint.z || transform.position.z <= startpoint.z)
                    turning = true;
            }
        }
    }

    public void OnCollision(Collision col)
    {
        if (col.gameObject.tag == "Player")
            Reset();
    }

    protected void Reset()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
