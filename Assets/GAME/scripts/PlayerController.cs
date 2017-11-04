using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {
    
    public Transform handL, handR;
    GameObject Head;
    public GameObject HUD;

    public int MAX_LIVES;
    int lives;

    //public float MAX_LIGHTING_DIST;
    //public float RESTART_GAME_AFTER_DEATH;
    //float bloodSplatterAlpha = 0;
    //float timerAfterDeath;
    
	// Use this for initialization
	void Start () {
        Head = GameObject.FindGameObjectWithTag("Head");
        lives = MAX_LIVES;

       // timerAfterDeath = 0;
    }
	
	// Update is called once per frame
	void Update () {
        //if (lives <= 0)
        //{
        //    timerAfterDeath += Time.deltaTime;

        //    if(timerAfterDeath > RESTART_GAME_AFTER_DEATH)//TEMP
        //    {
        //        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        //    }
        //    return;
        //}
    }

    public void Shoot(int num)//number of weapon
    {
        if (lives <= 0)
            return;

        switch (num)
        {
            case 0:
               // GameObject fire = GameObject.Instantiate(fireballPrefab, handR.transform.position, handR.transform.rotation);
                //fire.GetComponent<FireballScript>().Init(handR.transform.forward);
                break;
            default:
                break;
        }
        
    }

    public void Damage()
    {
        if (lives <= 0)
            return;

        lives--;
        
        if (lives < 0)
            lives = 0;
        
        //bloodSplatterAlpha = 1.0f - (float)((double)lives / (double)MAX_LIVES);
        //Color color = new Color(1, 1, 1, bloodSplatterAlpha);// bloodSplatter.GetComponent<Image>().color;
        ////color.a = bloodSplatterAlpha;
        //bloodSplatter.GetComponent<Image>().color = color;
        
        if (lives <= 0)
        {
            Die();
            //timerAfterDeath = 0;
        }
    }

    public void Die()
    {

    }
}
