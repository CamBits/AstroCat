using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

[DebuggerDisplay("{" + nameof(DebuggerDisplay) + "(),nq}")]
public partial class itemEffectAnimation : MonoBehaviour
{

    public ItemType itemType;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Jetpack jetpack = collision.gameObject.GetComponent<Jetpack>();
            Animator anim = collision.gameObject.GetComponent<Animator>();

            // Type of tigger Activate
            switch (itemType)
            {
                case ItemType.ItemError:
                case ItemType.ItemNose:

                    anim.SetTrigger("NegativeHit");

                    break;

                case ItemType.ItemPositive:
                    anim.SetTrigger("PositiveHit");

                    break;
            }

        }



        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }

    private string DebuggerDisplay
    {
        get
        {
            return ToString();
        }
    }
}