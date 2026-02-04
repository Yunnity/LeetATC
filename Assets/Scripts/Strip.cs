using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Strip : MonoBehaviour
{
    [SerializeField] Image backgroundImg;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void HandleBox2ButtonClicked()
    {
        backgroundImg.color = new Color(1, 0.647f, 0, 1);
    }

    public void HandleAltitudeButtonClicked()
    {

    }

    public void HandleRemoverButtonClicked()
    {
        Destroy(gameObject);
    }

    public void HandleACKButtonClicked()
    {
        backgroundImg.color = Color.black;
    }
}
