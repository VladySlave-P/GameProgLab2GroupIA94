using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Collector : MonoBehaviour
{
    int meal = 0;

    [SerializeField] TextMeshProUGUI mealText;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Meal"))
        {
            Destroy(other.gameObject);
            meal++;
            transform.localScale += new Vector3(0.25f, 0.25f, 0.25f);
            mealText.text = "Eated Trees: " + meal;
            if (meal == 4)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }
    }

}
