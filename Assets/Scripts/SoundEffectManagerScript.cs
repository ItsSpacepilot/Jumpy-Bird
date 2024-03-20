using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffectManagerScript : MonoBehaviour
{
    public static SoundEffectManagerScript intance;
    [SerializeField] private AudioSource soundEffectGameobject;


    private void Awake()
    {
        if (intance == null)
        {
            intance = this;
        }
    }

    public void PlaySoundEffect(AudioClip soundEffectClip, Transform spawnTransform, float volume)
    {
        AudioSource soundEffectSource = Instantiate(soundEffectGameobject, spawnTransform.position, Quaternion.identity);

        soundEffectSource.clip = soundEffectClip;
        soundEffectSource.volume = volume;

        float clipLength = soundEffectSource.clip.length;

        soundEffectSource.Play();
        Destroy(soundEffectSource.gameObject, clipLength);
    }
}
