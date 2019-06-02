﻿using UnityEngine;
using UnityEngine.UI;

namespace MintAnimation
{
    [AddComponentMenu("MintAnimation/ColorAnimation" , 1)]
    public class MintAnimation_Color : MintAnimation_Base<Color>
    {
        private Color               mGetColor;
        private Graphic             mGrahic;
        private Material            mMaterail;

        protected override void init()
        {
            this.mGrahic = this.gameObject.GetComponent<Graphic>();
            var m = this.gameObject.GetComponent<MeshRenderer>();
            if (m != null) this.mMaterail = m.material;
            AnimationInfo.AutoStartValue = false;
            base.init();
        }

        protected override Color getter()
        {
            return mGetColor;
        }

        protected override void setter(Color rColor)
        {
            this.mGetColor = rColor;

            if (this.mGrahic != null)
            {
                this.mGrahic.color = rColor;
            }
            if (this.mMaterail != null)
            {
                this.mMaterail.color = rColor;
            }
        }
    }
}
