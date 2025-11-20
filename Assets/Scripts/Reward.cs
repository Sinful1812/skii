using UnityEngine;

public class Reward : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Player player = other.GetComponent<Player>();

        player.Score += 1;

        string s = string.Format("+1 food\nYour food is {0}", player.Score);

        UIManager.instance.ShowNotiText(s);

        Destroy(gameObject);
    }
}

