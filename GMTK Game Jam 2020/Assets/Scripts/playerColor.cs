using UnityEngine;

public class playerColor : MonoBehaviour
{
    public Color backgroundTesting;
    public GameObject currentIndexController;
    int currentIndex;

    public Color white1;
    public Color blue1;
    public Color red1;
    public Color green1;
    public Color black1;
    public Color purple1;
    public Color yellow1;

    public Sprite whiteFront;
    public Sprite whiteBack;
    public Sprite whiteRight;
    public Sprite whiteLeft;

    public Sprite blueFront;
    public Sprite blueBack;
    public Sprite blueRight;
    public Sprite blueLeft;

    public Sprite redFront;
    public Sprite redBack;
    public Sprite redRight;
    public Sprite redLeft;

    public Sprite greenFront;
    public Sprite greenBack;
    public Sprite greenRight;
    public Sprite greenLeft;

    public Sprite blackFront;
    public Sprite blackBack;
    public Sprite blackRight;
    public Sprite blackLeft;

    public Sprite purpleFront;
    public Sprite purpleBack;
    public Sprite purpleRight;
    public Sprite purpleLeft;

    public Sprite yellowFront;
    public Sprite yellowBack;
    public Sprite yellowRight;
    public Sprite yellowLeft;

    // Start is called before the first frame update
    void Start()
    {
        backgroundTesting = white1;
    }

    // Update is called once per frame
    void Update()
    {

        currentIndex = currentIndexController.GetComponent<cameraBackground>().colorIndex;

        if (currentIndex == 0)
        {
            

            if (Input.GetAxisRaw("Vertical") == -1f)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = whiteFront;
            }

            if (Input.GetAxisRaw("Vertical") == 1f)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = whiteBack;
            }

            if (Input.GetAxisRaw("Horizontal") == 1f)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = whiteRight;
            }

            if (Input.GetAxisRaw("Horizontal") == -1f)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = whiteLeft;
            }

        }

        if (currentIndex == 2)
        {

            

            if (Input.GetAxisRaw("Vertical") == -1f)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = blueFront;
            }

            if (Input.GetAxisRaw("Vertical") == 1f)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = blueBack;
            }

            if (Input.GetAxisRaw("Horizontal") == 1f)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = blueRight;
            }

            if (Input.GetAxisRaw("Horizontal") == -1f)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = blueLeft;
            }

        }

        if (currentIndex == 1)
        {

            

            if (Input.GetAxisRaw("Vertical") == -1f)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = redFront;
            }

            if (Input.GetAxisRaw("Vertical") == 1f)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = redBack;
            }

            if (Input.GetAxisRaw("Horizontal") == 1f)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = redRight;
            }

            if (Input.GetAxisRaw("Horizontal") == -1f)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = redLeft;
            }

        }

        if (currentIndex == 3)
        {

            if (Input.GetAxisRaw("Vertical") == -1f)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = greenFront;
            }

            if (Input.GetAxisRaw("Vertical") == 1f)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = greenBack;
            }

            if (Input.GetAxisRaw("Horizontal") == 1f)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = greenRight;
            }

            if (Input.GetAxisRaw("Horizontal") == -1f)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = greenLeft;
            }

        }

        if (backgroundTesting == black1)
        {

            if (Input.GetAxisRaw("Vertical") == -1f)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = blackFront;
            }

            if (Input.GetAxisRaw("Vertical") == 1f)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = blackBack;
            }

            if (Input.GetAxisRaw("Horizontal") == 1f)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = blackRight;
            }

            if (Input.GetAxisRaw("Horizontal") == -1f)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = blackLeft;
            }

        }

        if (backgroundTesting == purple1)
        {

            if (Input.GetAxisRaw("Vertical") == -1f)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = purpleFront;
            }

            if (Input.GetAxisRaw("Vertical") == 1f)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = purpleBack;
            }

            if (Input.GetAxisRaw("Horizontal") == 1f)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = purpleRight;
            }

            if (Input.GetAxisRaw("Horizontal") == -1f)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = purpleLeft;
            }

        }

        if (backgroundTesting == yellow1)
        {

            if (Input.GetAxisRaw("Vertical") == -1f)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = yellowFront;
            }

            if (Input.GetAxisRaw("Vertical") == 1f)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = yellowBack;
            }

            if (Input.GetAxisRaw("Horizontal") == 1f)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = yellowRight;
            }

            if (Input.GetAxisRaw("Horizontal") == -1f)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = yellowLeft;
            }

        }

    }
}
