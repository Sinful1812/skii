using UnityEngine;
using UnityEngine.SocialPlatforms;

public class Tree : MonoBehaviour
{
    private Renderer rd;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rd = GetComponent<Renderer>();
    }

    private void OnCollisionEnter(Collision collision)

    {
        rd.material.color = Color.red;

        Player player = collision.gameObject.GetComponent<Player>();

        player.HP -= 25;

        string s = string.Format("Hit (-15)\nRemaining HP: {0}", player.HP);

        UIManager.instance.ShowNotiText(s);

        if (player.HP <= 0)

        {

            player.HP = 0;

            UIManager.instance.ShowNotiText("You are dead!");
            //Time.timeScale = 0;
            
        }

    }
    private void OnCollisionExit(Collision collision)

    {

        rd.material.color = new Color32(255, 158, 67, 255);

    }
}
