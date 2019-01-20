using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

namespace Vuforia
{
    public class targetData : MonoBehaviour
    {
        public Transform TextTargetName;
        public Transform TextDescription;
        //public Transform ButtonAction;
        public Transform PanelDescription;

        //   public UnityEngine.Video.VideoPlayer video;
        //    UnityEngine.Video.VideoClip clipTarget;
        //  public  soundTarget;
        //  public VideoClip clipTarget

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            StateManager sm = TrackerManager.Instance.GetStateManager();
            IEnumerable<TrackableBehaviour> tbs = sm.GetActiveTrackableBehaviours();
            foreach (TrackableBehaviour tb in tbs)
            {
                string name = tb.TrackableName;
                ImageTarget it = tb.Trackable as ImageTarget;
                Vector2 size = it.GetSize();
                Debug.Log("Active image target:" + name + " -size:" + size.x + "," + size.y);

                //Evertime the target found it will show “name of target” on the
                //  TextTargetName.Button, Description and Panel will visible(active)


                TextTargetName.GetComponent<Text>().text = name;
              //  ButtonAction.gameObject.SetActive(true);
                TextDescription.gameObject.SetActive(true);
                PanelDescription.gameObject.SetActive(true);

                if (name == "G_astro")
                {
                    //ButtonAction.GetComponent & lt; Button & gt; ().onClick.AddListener(delegate {
                    // playSound(&quot; sounds / ZombieLongDeath & quot;);});
                    TextDescription.GetComponent<Text>().text = "20-year-old Sima Azimi is teaching young women in Kabul a Chinese martial art called wushu. Women are discouraged from contact sports in Afghanistan, but Sima is fighting against gender prejudice. She hopes her classes will help her students feel safer in a country plagued by insecurity.";
                }

                if (name == "G_Leadership")
                {
                    Debug.Log("betty is found");
                    TextDescription.GetComponent<Text>().text = "On Leadership: In fields which were previously dominated by men, it takes affirmative action and advocation to allow women to enter and excel in these fields.";
                }



                if (name == "B_feelings")
                {
                    TextDescription.GetComponent<Text>().text = "In this audition of the Voice, Simon cowell is touched by the contestant's singing and sheds a few tears. It shows that vulnerability idn't something to hide.";

                }
            }

            //function to play video

        }
    }
}
