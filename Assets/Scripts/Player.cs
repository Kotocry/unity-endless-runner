using UnityEngine;

public class Player : MonoBehaviour
{
    public int variable1; // Widoczne w Inspectorze; Dostępne dla innych klas/skryptów
    private int variable2; // Niewidoczne w Inspectorze; Niedostępne dla innych klas/skryptów
    [SerializeField] private int variable3; // Widoczny w Inspectorze; Niedostępny dla innych klas
    [HideInInspector] public int variable4; //Niewidoczne w Inspectorze; Dostępne dla innych klas

    [SerializeField] private float movementSpeed = 7f;
    [SerializeField] private int linesCount = 3;
    [SerializeField] private float horizontalStep = 10f;

    private int line = 0;

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        transform.Translate(Vector3.forward * movementSpeed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.LeftArrow) && line > (-linesCount / 2))
        {
            // line = line - 1
            line -= 1;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow) && line < (linesCount / 2))
        {
            //line = line + 1
            line += 1;
        }

        transform.position = new Vector3(line * horizontalStep, transform.position.y, transform.position.z);
    }
}
