using UnityEngine;
using TMPro;
public class MouseController : MonoBehaviour
{
    public float damage, money;
    [SerializeField] TMP_Text moneytext, damageText;
    void Update(){
        transform.root.transform.position = new Vector3(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y, 0);
        if (Input.GetKeyDown(KeyCode.Mouse0)) GetComponentInParent<Animator>().SetTrigger("Attack");}
    private void OnCollisionEnter2D(Collision2D collision){
        if (collision.gameObject.CompareTag("Enemy")) collision.gameObject.GetComponent<Health>().Hit(1);}
    public void UpdateMoneyAndDamage(float _money, float _damage){
        money += _money;
        damage += _damage;
        moneytext.text = "$"+money.ToString("F2");
        damageText.text = damage.ToString() + " power";}
}