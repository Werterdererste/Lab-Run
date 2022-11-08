using UnityEngine;

public class VerfolgendeZone : MonoBehaviour
{
    public Transform Player;

    int Entfernung = 17;
    float speed = 5;
    Vector3 lastposition;
    public AudioSource hit;
    float lautstärke = 1f;
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 9)
        {
            Handheld.Vibrate();
            hit.Play();
            gameObject.GetComponent<AudioSource>().volume = lautstärke;
            Debug.Log("tod stehengeblieben");
            PlayerPrefs.SetInt("zohne", PlayerPrefs.GetInt("zohne") + 1);

            GameObject.Find("UI_Handler").GetComponent<UI_Handler>().GameOver();
        }
    }
    void Start()
    {
        lastposition = Player.position;
        lautstärke = PlayerPrefs.GetFloat("Sound");
    }
    void Update()
    {
        if (IsPlayerRun())
        {
            // spieler bewegt zohne auf ausgangssituation
            transform.position = new Vector3(Player.position.x - Entfernung, 0, 0);
        }
        else
        {
            // spieler steht zohne bewegt sich
            transform.Translate(speed * Time.deltaTime, 0, 0);
        }
        lastposition = Player.position;
    }
    public bool IsPlayerRun()
    {
        if (lastposition.x >= Player.position.x && playerMovement.gamestarts && !UI_Handler.ispause &&
        !GameObject.Find("UI_Handler").GetComponent<UI_Handler>().isgameover)
        {
            return false;
        }
        else
            return true;
    }
}