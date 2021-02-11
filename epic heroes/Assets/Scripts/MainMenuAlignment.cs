using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuAlignment : MonoBehaviour
{
    public Canvas canvas;

    // background image
    public Image backgroundImage;
    private float aDecentlyBigNumber = 10000f;

    // bottom navigation buttons
    public Button homeButton;
    public Button heroesButton;
    public Button itemsButton;
    public Button questsButton;
    public Button summonButton;
    public Button friendsButton;

    // right main buttons
    public Button eventButton;
    public Button storyButton;
    public Button underworldButton;

    // Start is called before the first frame update
    void Start()
    {

        float canvasx = canvas.GetComponent<RectTransform>().sizeDelta.x;
        float canvasy = canvas.GetComponent<RectTransform>().sizeDelta.y;

        // background image
        float backgroundImageWidth = backgroundImage.GetComponent<Image>().sprite.rect.width;
        float backgroundImageHeight = backgroundImage.GetComponent<Image>().sprite.rect.height;

        if (canvasx/canvasy > backgroundImageWidth/backgroundImageHeight){
            backgroundImage.GetComponent<RectTransform>().sizeDelta = new Vector2 (canvasx, aDecentlyBigNumber);
        }else{
            backgroundImage.GetComponent<RectTransform>().sizeDelta = new Vector2 (aDecentlyBigNumber, canvasy);
        }
        
        // bottom navigation buttons
        float bottomNavigationButtonWidth = canvasx/6;
        float bottomNavigationButtonHeight = 60f;

        homeButton.GetComponent<RectTransform>().localPosition = new Vector3 (-2.5f * bottomNavigationButtonWidth, (-canvasy + bottomNavigationButtonHeight) / 2, 0);
        homeButton.GetComponent<RectTransform>().sizeDelta = new Vector2 (bottomNavigationButtonWidth,bottomNavigationButtonHeight);
        heroesButton.GetComponent<RectTransform>().localPosition = new Vector3 (-1.5f * bottomNavigationButtonWidth, (-canvasy + bottomNavigationButtonHeight) / 2, 0);
        heroesButton.GetComponent<RectTransform>().sizeDelta = new Vector2 (bottomNavigationButtonWidth,bottomNavigationButtonHeight);
        itemsButton.GetComponent<RectTransform>().localPosition = new Vector3 (-0.5f * bottomNavigationButtonWidth, (-canvasy + bottomNavigationButtonHeight) / 2, 0);
        itemsButton.GetComponent<RectTransform>().sizeDelta = new Vector2 (bottomNavigationButtonWidth,bottomNavigationButtonHeight);
        questsButton.GetComponent<RectTransform>().localPosition = new Vector3 (0.5f * bottomNavigationButtonWidth, (-canvasy + bottomNavigationButtonHeight) / 2, 0);
        questsButton.GetComponent<RectTransform>().sizeDelta = new Vector2 (bottomNavigationButtonWidth,bottomNavigationButtonHeight);
        summonButton.GetComponent<RectTransform>().localPosition = new Vector3 (1.5f * bottomNavigationButtonWidth, (-canvasy + bottomNavigationButtonHeight) / 2, 0);
        summonButton.GetComponent<RectTransform>().sizeDelta = new Vector2 (bottomNavigationButtonWidth,bottomNavigationButtonHeight);
        friendsButton.GetComponent<RectTransform>().localPosition = new Vector3 (2.5f * bottomNavigationButtonWidth, (-canvasy + bottomNavigationButtonHeight) / 2, 0);
        friendsButton.GetComponent<RectTransform>().sizeDelta = new Vector2 (bottomNavigationButtonWidth,bottomNavigationButtonHeight);

        // right main buttons
        float rightMainButtonWidth = 300f;
        float rightMainButtonHeight = 185f;
        float rightMainButtonSpacing = 5f;

        eventButton.GetComponent<RectTransform>().localPosition = new Vector3 ((canvasx - rightMainButtonWidth) / 2, -canvasy / 2 + bottomNavigationButtonHeight + 3 * rightMainButtonSpacing + 2.5f * rightMainButtonHeight, 0);
        eventButton.GetComponent<RectTransform>().sizeDelta = new Vector2 (rightMainButtonWidth, rightMainButtonHeight);
        storyButton.GetComponent<RectTransform>().localPosition = new Vector3 ((canvasx - rightMainButtonWidth) / 2, -canvasy / 2 + bottomNavigationButtonHeight + 2 * rightMainButtonSpacing + 1.5f * rightMainButtonHeight, 0);
        storyButton.GetComponent<RectTransform>().sizeDelta = new Vector2 (rightMainButtonWidth, rightMainButtonHeight);
        underworldButton.GetComponent<RectTransform>().localPosition = new Vector3 ((canvasx - rightMainButtonWidth) / 2, -canvasy / 2 + bottomNavigationButtonHeight + rightMainButtonSpacing + 0.5f * rightMainButtonHeight, 0);
        underworldButton.GetComponent<RectTransform>().sizeDelta = new Vector2 (rightMainButtonWidth, rightMainButtonHeight);
        


    }
}
