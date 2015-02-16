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
        private string photoAddress = null;
        private string photoDescription = null;

        public PictureUri()
        {
        }

        public virtual string PhotoAddress
        {
            get
            {
                return photoAddress;
            }
            protected set
            {
                this.photoAddress = value;
            }
        }

        public virtual string WebSiteAddress
        {
            get
            {
                return this.PhotoAddress;
            }
        }

        public virtual string PhotoDescription
        {
            get
            {
                return photoDescription;
            }
            protected set
            {
                this.photoDescription = value;
            }
        }

        public abstract string ProviderDescription
        {
            get;
        }

        public abstract Task Update();
    }
}
