using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Audio;

public class AudioMixerScript : MonoBehaviour
{
    [SerializeField] AudioMixer gameAudiomixer;

    private const string MASTER_VOLUME = "Master Volume";

    public void ChangeMasterVolume(float Volume)
    {
        gameAudiomixer.SetFloat(MASTER_VOLUME, math.log10(Volume) * 20f);
    }

}
