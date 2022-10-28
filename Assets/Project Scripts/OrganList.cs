using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class OrganList : MonoBehaviour
{
    [SerializeField]
    private ImageConversion brainImage;
    [SerializeField]
    private ImageConversion heartImage;
    [SerializeField]
    private ImageConversion stomachImage; 
    [SerializeField]
    private ImageConversion bladderImage;
    [SerializeField]
    private TMP_TextInfo infoText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnBrainFound() 
    {
        Debug.Log("Brain is found");
        infoText.text = "Brain is found";
        brainImage.color = new Color(1, 1, 1);
    
    }
        public void OnStomachFound()
    {
        Debug.Log("Stomach is found");
        infoText.text = "Stomach is found";
        stomachImage.color = new Color(1, 1, 1);

    }
        public void OnHeartFound()
    {
        Debug.Log("Heart is found");
        infoText.text = "Heart is found";
        heartImage.color = new Color(1, 1, 1);
    }
    public void OnBladderFound()
    {
        Debug.Log("bladder is found");
        infoText.text = "bladder is found";
        bladderImage.color = new Color(1, 1, 1);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
