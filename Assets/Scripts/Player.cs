using UnityEngine;

public class Player : MonoBehaviour
{
    private void Awake()
    {
        if (!CustomDataSaver.HasKey("u_name"))
        {
            CustomDataSaver.SetString("u_name", "John");
        }

        if (!CustomDataSaver.HasKey("is_passed"))
        {
            CustomDataSaver.SetBool("is_passed", false);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(CustomDataSaver.GetString("u_name"));
        Debug.Log(CustomDataSaver.GetBool("is_passed"));
    }
}
