using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SubmitRockets : MonoBehaviour
{
    public TextMeshProUGUI output;
    public TMP_InputField rocket_kronus;
    public TMP_InputField rocket_lyrion;
    public TMP_InputField rocket_mystara;
    public TMP_InputField rocket_eclipsia;
    public TMP_InputField rocket_fiora;

    public void ButtonPress()
    {
        int kronus, lyrion, mystara, eclipsia, fiora;

        bool isKronusValid = int.TryParse(rocket_kronus.text, out kronus);
        bool isLyrionValid = int.TryParse(rocket_lyrion.text, out lyrion);
        bool isMystaraValid = int.TryParse(rocket_mystara.text, out mystara);
        bool isEclipsiaValid = int.TryParse(rocket_eclipsia.text, out eclipsia);
        bool isFioraValid = int.TryParse(rocket_fiora.text, out fiora);

        if (isKronusValid && isLyrionValid && isMystaraValid && isEclipsiaValid && isFioraValid)
        {
            int[] rockets = { kronus, lyrion, mystara, eclipsia, fiora };
            int rocket_total = kronus + lyrion + mystara + eclipsia + fiora;

            for (int i = 0; i < rockets.Length; i++)
            {
                if (rockets[i] < 0 || rockets[i] > 1000)
                {
                    output.text = "Enter numbers between 0 and 1000";
                    return;
                }
            }

            if (!(kronus >= lyrion && lyrion >= mystara && mystara >= eclipsia && eclipsia >= fiora))
            {
                output.text = "Assign rockets in non-increasing order";
                    
            }
            else if (rocket_total != 1000 )
            {     
                output.text = "Rockets are not equal to 1000";
            }
            else
            {
                output.text = "Total rockets: " + rocket_total;
            }
        }
        else
        {
            output.text = "Invalid input. Enter numbers only";
        }

    }
}
