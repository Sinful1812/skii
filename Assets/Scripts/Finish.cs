using UnityEngine;

public class Finish : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Player player = other.GetComponent<Player>();
        player.Score += 100;

        

        string s = string.Format("Nah..i'd Win\nYour score is: {0}", player.Score);
        UIManager.instance.ShowNotiText(s);

    }
}
