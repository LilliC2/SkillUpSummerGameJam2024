using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public GameObject gameOverScreen, sword;
    public TMP_Text roundText, upgradeText;
    public float upgradeCost;
    public MouseController mouseController;
    public void EndGame(){
        gameOverScreen.SetActive(true);
        Time.timeScale = 0;}
    public void SceneMangement(int index){
        roundText.text = "You reached round " + Object.FindFirstObjectByType<EnemySpawner>().round;
        if (index == 0) SceneManager.LoadScene("GameScene");
        else if (index == 1) Application.Quit();}
    public void UpgradeSword(){
        if(mouseController.money>= upgradeCost){
            mouseController.money -= upgradeCost;
            upgradeCost *= 1.3f;
            upgradeText.text = "upgrade sword " + upgradeCost.ToString("F2");
            sword.transform.localScale = new Vector3(sword.transform.localScale.x, sword.transform.localScale.y+1, sword.transform.localScale.z);
            mouseController.UpdateMoneyAndDamage(0, 1);
        }}
}