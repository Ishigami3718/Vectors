using UnityEngine;

public class Move : MonoBehaviour
{
    public GameObject goal;
    Vector3 direction;
    public float speed = 2f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {
        direction = goal.transform.position - this.transform.position;
        this.transform.LookAt(goal.transform.position);
        if (direction.magnitude < 2) return;
        Vector3 velocity = direction.normalized * speed * Time.deltaTime;
        this.transform.position += velocity;
    }
}
