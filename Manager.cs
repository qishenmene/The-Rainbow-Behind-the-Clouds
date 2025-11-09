using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public TextMeshProUGUI speakerName;
    public TextMeshProUGUI speakingContents;

    private string filePath = Constants.STORY_PATH;
    private List<ExcelReader.ExcelData> storyData;
    private int currentLine = 0;
    // Start is called before the first frame update
    void Start()
    {
        LoadStoryFromFile(filePath);
        DisplayNextLine();
    }

    void Update()
    {
        if(input.GetMouseButtonDown(0))
        {
            DisplayNextLine();
        }
    }

    void LoadStoryFromFile(string path)
    {
        storyData = ExcelReader.ReadExcel(path);
        if(storyData == null || storyData.Count == 0)
        {
            Debug.LogError("No data found in the file");
        }
    }

    void DisplayNextLine()
    {
        if(current_line >= storyData.Count)
        {
            Debug.Log("End of story");
            return;
        }
        var data = storyData[current_line];
        speakerName.text = data.speaker;
        speakingContents.text = data.content;
        current_line++;
    }

    void UpdateBackgroundImage(string imageFileName)
    {
        string imagePath = Constant.BACKGROUND_PATH;
        Sprite sprite = Resources.Load<Sprite>(imagePath);
        if (sprite != null)
        {
            backgroundImage.sprite = sprite;
        }
        else
        {
            Debug.LogError(Constant.IMAGE_LOAD_FAILED + imagePath);
        }
    }
 
}
