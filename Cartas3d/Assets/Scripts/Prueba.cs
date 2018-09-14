using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prueba : MonoBehaviour {

    public Material uno;
    public Material dos;
    public Material tres;
    public GameObject[] cartas;
    
    // Use this for initialization
    void Start()
    {

        //int numero;
        
        //int contadorPerros = 0;
        //int contadorVacas = 0;
        //int contadorMonos = 0;

        int[] arrayNum = { 1, 1, 1, 2, 2, 2, 3, 3, 3 };
        for (int i=arrayNum.Length-1; i>0; i--)
        {
            int j = Random.Range(0, arrayNum.Length);

            var tmp = arrayNum[j];
            arrayNum[j] = arrayNum[i];
            arrayNum[i] = tmp;
        }

        for (int k =0; k<9; k++)
        {
            if (arrayNum[k]== 1)
            {
                cartas[k].gameObject.GetComponent<MeshRenderer>().material = uno;
            }else if (arrayNum[k] == 2)
            {
                cartas[k].gameObject.GetComponent<MeshRenderer>().material = dos;
            }
            if (arrayNum[k] == 3)
            {
                cartas[k].gameObject.GetComponent<MeshRenderer>().material = tres;
            }


        }

        /*

        for(int i = 0; i < 9; i++)
        {


            numero = numeroRandom(contadorVacas,contadorPerros,contadorMonos);

            if (numero == 1 && contadorVacas < 3)
            {
                cartas[i].gameObject.GetComponent<MeshRenderer>().material = uno;
                contadorVacas++;

            }
            else if (numero == 2 && contadorPerros < 3)
            {
                cartas[i].gameObject.GetComponent<MeshRenderer>().material = dos;
                contadorPerros++;
            }
            else if (numero == 3 && contadorMonos < 3)
            {

                cartas[i].gameObject.GetComponent<MeshRenderer>().material = tres;
                contadorMonos++;

                //MONOS
            }
            else if (numero == 1 && contadorMonos > 3 && contadorPerros < 3)
            {
                cartas[i].gameObject.GetComponent<MeshRenderer>().material = dos;
                contadorPerros++;

            }
            else if (numero == 1 && contadorMonos > 3 && contadorPerros > 3 && contadorVacas < 2)
            {
                cartas[i].gameObject.GetComponent<MeshRenderer>().material = uno;
                contadorVacas++;


            }
            else if (numero == 1 && contadorMonos > 3 && contadorPerros < 3 && contadorVacas >3)
            {

                cartas[i].gameObject.GetComponent<MeshRenderer>().material = tres;
                contadorVacas++;
            }
            else if (numero == 1 && contadorMonos >3 && contadorVacas < 3){

            }//PERROS
            else if (numero == 2 && contadorPerros > 3 && contadorMonos < 3)
            {

            }
            else if (numero == 2 && contadorPerros > 3 && contadorMonos > 3 && contadorVacas < 2)
            {



            }
            else if (numero == 2 && contadorPerros > 3 && contadorMonos < 3 && contadorVacas > 3)
            {


            }
            else if (numero == 2 && contadorPerros > 3 && contadorVacas < 3)
            {

            }//VACAS
            else if (numero == 3 && contadorVacas > 3 && contadorPerros < 3)
            {

            }
            else if (numero == 3 && contadorVacas > 3 && contadorPerros > 3 && contadorMonos < 2)
            {



            }
            else if (numero == 3 && contadorVacas > 3 && contadorPerros < 3 && contadorMonos > 3)
            {


            }
            else if (numero == 3 && contadorVacas > 3 && contadorMonos < 3)
            {

            }



        }
        */

        










    }

    



}
