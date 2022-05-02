using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Navigation : MonoBehaviour
{

   // public AudioSource musiquinha;
   // public Scrollbar volume;


    //Janelas principal
    public GameObject Menu_Meio, Menu_Lateral;

    //janela navega��o

        public GameObject BuildYourteam_janela, Compendium_janela;


    //Bot�es
    public GameObject IdlePVE_Bot�o,Champions_Bot�o,Compendium_Bot�o,BuildYourteam_Bot�o,Options_Bot�o, Options_Bot�o2;




    // Start is called before the first frame update
    public void Start()
    {
        
    }

    // Update is called once per frame
    public void Update()
    {
       // musiquinha.volume = volume.value;

    }

    public void testando()
    {
       
    }
    

    //fun��es 

    public void Champions_click()
    {
        if (Compendium_Bot�o.activeInHierarchy == false) {
           
            Compendium_Bot�o.SetActive(true);
            BuildYourteam_Bot�o.SetActive(true);
            Options_Bot�o2.SetActive(true);
            Options_Bot�o.SetActive(false);
        }
        else 
        {

            Compendium_Bot�o.SetActive(false);
            BuildYourteam_Bot�o.SetActive(false);
            Options_Bot�o2.SetActive(false);
            Options_Bot�o.SetActive(true);
        }
        
        if (Menu_Meio.activeInHierarchy == true)
        {
            Menu_Meio.SetActive(false);
            Menu_Lateral.SetActive(true);
            Compendium_Bot�o.SetActive(true);
            BuildYourteam_Bot�o.SetActive(true);
            Options_Bot�o2.SetActive(true);
            Options_Bot�o.SetActive(false);
        }
        


    }
    public void Compemdium_click()
    {
        if (Menu_Lateral.activeInHierarchy == true && Menu_Meio.activeInHierarchy == false)
        {
            Compendium_janela.SetActive(true);
            BuildYourteam_janela.SetActive(false);
        }
        

    }
    public void BuildYourTeam_click()
    {
        if (Menu_Lateral.activeInHierarchy == true && Menu_Meio.activeInHierarchy == false)
        {
            Compendium_janela.SetActive(false);
            BuildYourteam_janela.SetActive(true);
        }

    }

   

}
