using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class OptionsWindow : MonoBehaviour
{

    [SerializeField]
    private AudioSource audioSourceMusicBubbles, audioSourceMusicMelody, audioSourceSound;
    [SerializeField]
    private Text textMusic, textSound, textFullscreen;
    [SerializeField]
    private TMP_Dropdown resolutionDropdown;
    [SerializeField]
    private GameObject muteMusicButton, unmuteMusicButton, muteSoundButton, unmuteSoundButton;
    [SerializeField]
    private Slider musicSlider, soundSlider;

    Resolution[] resolutions;
    float musicVolumeBeforeMute, soundVolumeBeforeMute;

    private void Start()
    {
        musicVolumeBeforeMute = 80.0f;
        soundVolumeBeforeMute = 80.0f;

        resolutions = Screen.resolutions;
       
        resolutionDropdown.ClearOptions();

        List<string> options = new List<string>();

        int currentResolutionIndex = 0;

        for (int i = 0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width + "×" + resolutions[i].height;
            options.Add(option);

            if (resolutions[i].width == Screen.currentResolution.width &&
                resolutions[i].height == Screen.currentResolution.height)
            {
                currentResolutionIndex = i;
            }
        }

        resolutionDropdown.AddOptions(options);
        if (!System.IO.File.Exists(Application.persistentDataPath + "/config.json"))
        {
            resolutionDropdown.value = currentResolutionIndex;
            resolutionDropdown.RefreshShownValue();
        }
        else
        {
            // Loading settings
            ConfigJSON config = JSONHandler.ReadConfigFromJSON("config.json");
            FindInactiveHelper.FindObjectByName(GameObject.Find("Canvas_Holder"), "Music_Slider").GetComponent<Slider>().value = config.musicVolume;
            FindInactiveHelper.FindObjectByName(GameObject.Find("Canvas_Holder"), "Sound_Slider").GetComponent<Slider>().value = config.soundVolume;
            resolutionDropdown.value = config.resolution;
            resolutionDropdown.RefreshShownValue();
            SetResolution(config.resolution);
            FindInactiveHelper.FindObjectByName(GameObject.Find("Canvas_Holder"), "Full_Screen_Toggle").GetComponent<Toggle>().isOn = config.isFullScreen;
        }
    }

    public void SetResolution(int resolutionIndex)
    {
        Resolution resolution = resolutions[resolutionIndex];

        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }

    public void SetFullscreen(bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;

        if (isFullscreen)
        {
            textFullscreen.text = "On";
        }
        else
        {
            textFullscreen.text = "Off";
        }
    }

    public void SetVolumeMusic(float volume)
    {
        audioSourceMusicBubbles.volume = volume / 100;
        audioSourceMusicMelody.volume = volume / 100;

        textMusic.text = volume.ToString();

        if (volume == 0)
        {
            muteMusicButton.SetActive(false);
            unmuteMusicButton.SetActive(true);
        }
        else
        {
            muteMusicButton.SetActive(true);
            unmuteMusicButton.SetActive(false);
        }
    }

    public void SetVolumeSound(float volume)
    {
        audioSourceSound.volume = volume / 100;

        textSound.text = volume.ToString();

        if (volume == 0)
        {
            muteSoundButton.SetActive(false);
            unmuteSoundButton.SetActive(true);
        }
        else
        {
            muteSoundButton.SetActive(true);
            unmuteSoundButton.SetActive(false);
        }
    }

    public void MuteAndUnmuteMusic()
    {
        if (muteMusicButton.activeInHierarchy)
        {
            muteMusicButton.SetActive(false);
            unmuteMusicButton.SetActive(true);
            audioSourceMusicBubbles.volume = 0;
            audioSourceMusicMelody.volume = 0;
            textMusic.text = "0";
            musicVolumeBeforeMute = musicSlider.value;
            musicSlider.value = 0;
        }
        else
        {
            muteMusicButton.SetActive(true);
            unmuteMusicButton.SetActive(false);
            audioSourceMusicBubbles.volume = musicVolumeBeforeMute;
            audioSourceMusicMelody.volume = musicVolumeBeforeMute;
            textMusic.text = musicVolumeBeforeMute.ToString();
            musicSlider.value = musicVolumeBeforeMute;
        }
    }

    public void MuteAndUnmuteSound()
    {
        if (muteSoundButton.activeInHierarchy)
        {
            muteSoundButton.SetActive(false);
            unmuteSoundButton.SetActive(true);
            audioSourceSound.volume = 0;
            textSound.text = "0";
            soundVolumeBeforeMute = soundSlider.value;
            soundSlider.value = 0;
        }
        else
        {
            muteSoundButton.SetActive(true);
            unmuteSoundButton.SetActive(false);
            audioSourceSound.volume = soundVolumeBeforeMute;
            textSound.text = soundVolumeBeforeMute.ToString();
            soundSlider.value = soundVolumeBeforeMute;
        }
    }

}
