using UnityEngine;
using UnityEngine.Video;

public class VideoScript : MonoBehaviour
{
    public VideoPlayer _Video;
    
    public void btn_sentuh(int id)
    {
        if(id == 0)
        {
            _Video.Play();
        }
        else if(id == 1)
        {
            _Video.Pause();
        }
        else if(id == 2)
        {
            _Video.frame = _Video.frame + 300;
            _Video.Play();
        }
        else if(id == 3)
        {
            _Video.frame = _Video.frame - 300;
            _Video.Play();
        }
    }
}
