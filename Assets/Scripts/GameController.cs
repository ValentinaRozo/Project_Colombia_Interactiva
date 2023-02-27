using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class GameController : MonoBehaviour
{
    //Basic Information of each Department
    public GameObject department_Info;
    public TextMeshPro department_name;
    public TextMeshPro department_maininfo;

    //Assets of flora and fauna of each department
    public GameObject amazonasFlora_fauna;
    public GameObject magdalenaFlora_fauna;

    // Start is called before the first frame update
    void Start()
    {
        department_Info.SetActive(false);
        magdalenaFlora_fauna.SetActive(false);
        amazonasFlora_fauna.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClickDepartment(string depto)
    {
        if (depto == "Amazonas")
        {
            department_name.text = "Amazonas";
            department_maininfo.text = "Capital: Leticia\n" +
                "\nTemperatura: 22°C - 24°C\n";

            department_Info.SetActive(true);
            amazonasFlora_fauna.SetActive(true);
            magdalenaFlora_fauna.SetActive(false);
        }
        else if (depto == "Antioquia")
        {
            department_name.text = "Antioquia";
            department_maininfo.text = "Capital: Medellín\n" +
                "\nTemperatura: 27°C\n";

            department_Info.SetActive(true);
            amazonasFlora_fauna.SetActive(false);
            magdalenaFlora_fauna.SetActive(false);
        }
        else if (depto == "Arauca")
        {
            department_name.text = "Arauca";
            department_maininfo.text = "Capital: Arauca\n" +
                "\nTemperatura: 22°C - 35°C\n";

            department_Info.SetActive(true);
            amazonasFlora_fauna.SetActive(false);
            magdalenaFlora_fauna.SetActive(false);
        }
        else if (depto == "Atlantico")
        {
            department_name.text = "Atlantico";
            department_maininfo.text = "Capital: Barranquilla\n" +
                "\nTemperatura: 23°C - 33°C\n";

            department_Info.SetActive(true);
            amazonasFlora_fauna.SetActive(false);
            magdalenaFlora_fauna.SetActive(false);
        }
        else if (depto == "Narino")
        {
            department_name.text = "Nariño";
            department_maininfo.text = "Capital: Pasto\n" +
                "\nTemperatura: 26°C - 28°C\n";

            department_Info.SetActive(true);
            amazonasFlora_fauna.SetActive(false);
            magdalenaFlora_fauna.SetActive(false);
        }
        else if (depto == "Santander")
        {
            department_name.text = "Santander";
            department_maininfo.text = "Capital: Bucaramanga\n" +
                "\nTemperatura: 21°C - 24°C\n";

            department_Info.SetActive(true);
            amazonasFlora_fauna.SetActive(false);
            magdalenaFlora_fauna.SetActive(false);
        }
        else if (depto == "Sucre")
        {
            department_name.text = "Sucre";
            department_maininfo.text = "Capital: Sincelejo\n" +
                "\nTemperatura: 26°C - 28°C\n";

            department_Info.SetActive(true);
            amazonasFlora_fauna.SetActive(false);
            magdalenaFlora_fauna.SetActive(false);
        }
        else if (depto == "Tolima")
        {
            department_name.text = "Tolima";
            department_maininfo.text = "Capital: Ibagué\n" +
                "\nTemperatura: 17°C - 28°C\n";

            department_Info.SetActive(true);
            amazonasFlora_fauna.SetActive(false);
            magdalenaFlora_fauna.SetActive(false);
        }
        else if (depto == "Valle")
        {
            department_name.text = "Valle del Cauca";
            department_maininfo.text = "Capital: Cali\n" +
                "\nTemperatura: 24°C - 28°C\n";

            department_Info.SetActive(true);
            amazonasFlora_fauna.SetActive(false);
            magdalenaFlora_fauna.SetActive(false);
        }
        else if (depto == "Vaupes")
        {
            department_name.text = "Vaupés";
            department_maininfo.text = "Capital: Mitú\n" +
                "\nTemperatura: 25°C - 30°C\n";

            department_Info.SetActive(true);
            amazonasFlora_fauna.SetActive(false);
            magdalenaFlora_fauna.SetActive(false);
        }
        else if (depto == "Vichada")
        {
            department_name.text = "Vichada";
            department_maininfo.text = "Capital: Puerto Carreño\n" +
                "\nTemperatura: 25°C - 35°C\n";

            department_Info.SetActive(true);
            amazonasFlora_fauna.SetActive(false);
            magdalenaFlora_fauna.SetActive(false);
        }
        else if (depto == "Magdalena")
        {
            department_name.text = "Magdalena";
            department_maininfo.text = "Capital: Santa Marta\n" +
                "\nTemperatura: 25°C - 35°C\n";

            department_Info.SetActive(true);
            amazonasFlora_fauna.SetActive(false);
            magdalenaFlora_fauna.SetActive(true);
        }
    }
}
