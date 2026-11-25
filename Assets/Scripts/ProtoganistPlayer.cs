using DG.Tweening;
using JetBrains.Annotations;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class ProtoganistPlayer : MonoBehaviour
{
    public int protoHealth = 100;
    public Animator animaController;

    public TextMeshProUGUI healthText;

    public GameObject lightattackEffect, heavyattackEffect;

    public EnemyScript enemyScript;

    public Button heavyattackButton, lightattackButton;

    

    



    void Update() { }

    public void heavyAttack()

    {
        StartCoroutine(HeavyAttackRoutine());
    }

    private IEnumerator HeavyAttackRoutine()
    {
        transform.DOMove(new Vector3(1.5f, -2.2f, 0), 0.5f);
        if (animaController != null)
        {
            animaController.SetTrigger("HeavyAttack");
           

            
        }
        
        if (enemyScript != null)
        {
            enemyScript.GetAttacked(20);
        }

        if (heavyattackEffect != null)
        {
            heavyattackEffect.SetActive(false);
            heavyattackEffect.SetActive(true);

        }

        yield return new WaitForSeconds(1.4f);

        transform.DOMove(new Vector3(-3.5f, -2.2f, 0), 0.5f); //3.86 olacak düşman olunce
    }

    public void lightAttack()
    {
       StartCoroutine(lightAttackRoutine());
    }

     private IEnumerator lightAttackRoutine()
    {
        transform.DOMove(new Vector3(1.5f, -2.2f, 0), 0.5f);

        if (animaController != null)
        {
            animaController.SetTrigger("LightAttack");
            
      
        }

        if (lightattackEffect  != null)
        {
            lightattackEffect.SetActive(false);
            lightattackEffect.SetActive(true);
         
        }
            
        if (enemyScript != null)
            {
                enemyScript.GetAttacked(10);
              
            }
        yield return new WaitForSeconds(1.7f);

        transform.DOMove(new Vector3(-3.5f, -2.2f, 0), 0.5f); //3.86 olacak düşman olunce
    }

    
                  




  
    
}
