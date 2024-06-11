using UnityEngine;
public class EnemySpawner : MonoBehaviour
{
    public GameObject[] spawnPoints, enemies;
    public int round = 1;
    void Start(){
        InvokeRepeating("SpawnEnemy", 1, 3);
        InvokeRepeating("IncreaseRounds", 15, 15);}
    void SpawnEnemy(){
        for (int i = 0; i < round*2; i++){
            var enemy = Instantiate(enemies[Random.Range(0,enemies.Length)], spawnPoints[Random.Range(0, spawnPoints.Length)].transform.position, Quaternion.identity);
            enemy.GetComponent<Health>().maxHealth = enemy.GetComponent<Health>().maxHealth * round;
            enemy.GetComponent<Health>().health = enemy.GetComponent<Health>().maxHealth;
        }}
    void IncreaseRounds()
    { round++; }
}