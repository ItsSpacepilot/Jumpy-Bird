using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Audio;

public class AudioMixerScript : MonoBehaviour
{
    [SerializeField] AudioMixer gameAudiomixer;

    private const string MASTER_VOLUME = "Master Volume";
    private const string SOUNDEFFECT_VOLUME = "SoundEffect Volume";
    private const string SOUNDTRACK_VOLUME = "SoundTrack Volume";

    public void ChangeMasterVolume(float Volume)
    {
        gameAudiomixer.SetFloat(MASTER_VOLUME, math.log10(Volume) * 20f);
    }
    public void ChangeSoundEffectVolume(float Volume)
    {
        gameAudiomixer.SetFloat(SOUNDEFFECT_VOLUME, math.log10(Volume) * 20f);
    }
    public void ChangeSoundTrackVolume(float Volume)
    {
        gameAudiomixer.SetFloat(SOUNDTRACK_VOLUME, math.log10(Volume) * 20f);
    }

}
