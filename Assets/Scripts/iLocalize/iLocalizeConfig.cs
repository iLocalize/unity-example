
public class iLocalizeUserConfig {

    private string userTags;
    private string userId;

    public class Builder {
        private string userTags = "";
        private string userId = "";

        public Builder SetUserTags(string userTags) {
            this.userTags = userTags;
            return this;
        }
        public Builder SetUserId(string userId)
        {
            this.userId = userId;
            return this;
        }

        public iLocalizeUserConfig build() {
            return new iLocalizeUserConfig(userTags,userId);
        }

    }

    public string GetUserTags() {
        return userTags;
    }
    public string GetUserId()
    {
        return userId;
    }

    private iLocalizeUserConfig(string userTags, string userId) {
        this.userTags = userTags;
        this.userId = userId;
    }

}

public class iLCheckOverflowConfig
{
    private string pageId;
    private string stringId;
    private string stringRealContent;
    private float designWidth;
    private float designHeight;
    private float measuredWidth;
    private float measuredHeight;

    public class Builder
    {
        private string pageId = "";
        private string stringId = "";
        private string stringRealContent = "";
        private float designWidth = 0;
        private float designHeight = 0;
        private float measuredWidth = 0;
        private float measuredHeight = 0;

        public Builder SetPageId(string pageId)
        {
            this.pageId = pageId;
            return this;
        }
        public Builder SetStringId(string stringId)
        {
            this.stringId = stringId;
            return this;
        }
        public Builder SetStringRealContent(string stringRealContent)
        {
            this.stringRealContent = stringRealContent;
            return this;
        }
        public Builder SetDesignWidth(float designWidth)
        {
            this.designWidth = designWidth;
            return this;
        }
        public Builder SetDesignHeight(float designHeight)
        {
            this.designHeight = designHeight;
            return this;
        }
        public Builder SetMeasuredWidth(float measuredWidth)
        {
            this.measuredWidth = measuredWidth;
            return this;
        }
        public Builder SetMeasuredHeight(float measuredHeight)
        {
            this.measuredHeight = measuredHeight;
            return this;
        }

        public iLCheckOverflowConfig build()
        {
            return new iLCheckOverflowConfig(pageId, stringId, stringRealContent, designWidth, designHeight, measuredWidth, measuredHeight);
        }

    }

    public string GetPageId()
    {
        return pageId;
    }
    public string GetStringId()
    {
        return stringId;
    }
    public string GetStringRealContent()
    {
        return stringRealContent;
    }
    public float GetDesignWidth()
    {
        return designWidth;
    }
    public float GetDesignHeight()
    {
        return designHeight;
    }
    public float GetMeasuredWidth()
    {
        return measuredWidth;
    }
    public float GetMeasuredHeight()
    {
        return measuredHeight;
    }

    private iLCheckOverflowConfig(string pageId, string stringId, string stringRealContent, float designWidth, float designHeight, float measuredWidth, float measuredHeight)
    {
        this.pageId = pageId;
        this.stringId = stringId;
        this.stringRealContent = stringRealContent;
        this.designWidth = designWidth;
        this.designHeight = designHeight;
        this.measuredWidth = measuredWidth;
        this.measuredHeight = measuredHeight;
    }

}
