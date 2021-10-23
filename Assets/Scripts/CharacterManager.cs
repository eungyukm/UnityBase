using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CharacterManager : MonoBehaviour
{
    public Slider hpSlide;
    public float hp = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hpSlide.value = hp;

        if(hp < 0)
        {
            Time.timeScale = 0;
            Destroy(gameObject);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("Main");
            Time.timeScale = 1;
        }
    }
}
