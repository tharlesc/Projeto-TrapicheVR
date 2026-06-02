using UnityEngine;

public class PontoInteresseScript : MonoBehaviour
{
    public GameObject pontoInteresse;
    // public GameObject somEntrada;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter() {
        pontoInteresse.SetActive(true);
        // somEntrada.SetActive(true);
    }

    private void OnTriggerExit() {
        pontoInteresse.SetActive(false);
        // somEntrada.SetActive(false);
    }
}
