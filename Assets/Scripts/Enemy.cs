using UnityEngine;
using UnityEngine.AI;
public class Enemy : MonoBehaviour
{
    public NavMeshAgent agent;
    GameObject goal;
    public float attackPwr;
    public Animator anim;
    private void Start(){
        goal = GameObject.FindGameObjectWithTag("Goal");}
    void Update(){
        agent.SetDestination(goal.transform.position);
        if (Vector3.Distance(goal.transform.position, transform.position) <5f){
            anim.SetTrigger("Attack");
        } else agent.isStopped = false;
    }
    public void Destroy(){
        Destroy(gameObject);}
    public void Attack(){
        goal.GetComponent<Health>().Hit(attackPwr);}
}