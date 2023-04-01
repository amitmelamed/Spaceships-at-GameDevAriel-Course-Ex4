using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyOnTriggerBoss : MonoBehaviour
{
    // Start is called before the first frame update
    [Tooltip("Every object tagged with this tag will trigger the destruction of this object and will move to level 2")]
    [SerializeField] string triggeringTag;
    [SerializeField] string sceneName;


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == triggeringTag && enabled)
        {
            Destroy(this.gameObject);
            Destroy(other.gameObject);
            SceneManager.LoadScene(sceneName);

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
