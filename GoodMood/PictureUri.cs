/*
 * Copyright 2015 Andrea Del Signore sejerpz@gmail.com
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoodMood
{
    abstract class PictureUri
    {
        private string uri = null;
        private string description = null;

        public PictureUri()
        {
        }

        public virtual string Uri
        {
            get
            {
                return uri;
            }
            protected set
            {
                this.uri = value;
            }
        }

        public virtual string Description
        {
            get
            {
                return description;
            }
            protected set
            {
                this.description = value;
            }
        }

        public abstract Task Update();
    }
}
