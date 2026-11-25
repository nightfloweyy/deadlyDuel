using DG.Tweening;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class EnemyScript : MonoBehaviour
{
    public int enemyHealth = 100;
    public Animator enemyAnimController;
    public TextMeshProUGUI eHealthText;

    public UnityEngine.UI.Slider healthBar;
    public GameObject gameOverPanel,inGamePanel;





    public void GetAttacked(int damage)
    {
        enemyHealth = Mathf.Max(0, enemyHealth - damage);
        healthBar.value = enemyHealth;

        if (enemyAnimController != null)
        {
            enemyAnimController.SetTrigger("GetAttacked");
            eHealthText.text = "Enemy Health:" + enemyHealth;
        }

        if (enemyHealth <= 0)
        {
            Death();
            inGamePanel.SetActive(false);
            gameOverPanel.SetActive(true);
            return;
        }



    }


    public void Death()
    {
        if (enemyAnimController != null)
        {
            enemyAnimController.SetTrigger("Death");
        }
        
        transform.DOMove(new Vector3(3.5f, -3.86f, 0), 2f); //3.86 olacak düşman olunce
    }

     



    
    
}
