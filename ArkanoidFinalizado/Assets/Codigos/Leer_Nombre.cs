using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.IO;
using System.Text;

public class Leer_Nombre : MonoBehaviour {
    public Text nomJug; // nombre del jugador
     
    void Start()
    {

   
         FileStream archivo; // lee los valores iniciales del juego 
       StreamReader flujoIn;  // archivo
       // flujo de salida
        

        try
        {
            // abre el archivo con el nombre y lee el nombre
            archivo = new FileStream(Application.persistentDataPath+"/Nombre.txt", FileMode.OpenOrCreate, FileAccess.Read);
            flujoIn = new StreamReader(archivo, Encoding.Default);
            using (flujoIn)
            {
                nomJug.text = "Jugador: "+flujoIn.ReadLine();
              //  Debug.Log("" + flujoIn.ReadLine());
                
            } // fin del using


            
        } // fin del try
        catch (IOException e)
        {
            Debug.Log(e.Message);
        } // fin del try...catch */








}    


    
}
