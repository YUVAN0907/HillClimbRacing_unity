using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UImanager : MonoBehaviour
{
   public TextMeshProUGUI score;
    public Image life;
    public Sprite[] lives;
    private int value;
    public static UImanager instance;
    public GameObject end;
    void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void UpdateScore(int num)
    {
        value += num;
        score.text = "Burger :" + value;
    }
    public void UpdateLife(int y)
    {
        life.sprite = lives[y];
    }
    public void show()
    {
        end.SetActive(true);
        soundmanager.instance.playgameover();
    }
    public void retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
