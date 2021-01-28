
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

    private string fontFamily;
    private float fontSize;
    private float lineSpacing;
    private int textAlign;
    private bool isBold;
    private bool isItalic;
    private bool isMultipleLine;

    public class Builder
    {
        private string pageId = "";
        private string stringId = "";
        private string stringRealContent = "";
        private float designWidth = 0;
        private float designHeight = 0;
        private float measuredWidth = 0;
        private float measuredHeight = 0;

        private string fontFamily = "";
        private float fontSize = 0;
        private float lineSpacing = 0;
        private int textAlign = 0;
        private bool isBold = false;
        private bool isItalic = false;
        private bool isMultipleLine = false;

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

        public Builder SetFontFamily(string fontFamily)
        {
            this.fontFamily = fontFamily;
            return this;
        }

        public Builder SetFontSize(float fontSize)
        {
            this.fontSize = fontSize;
            return this;
        }

        public Builder SetLineSpacing(float lineSpacing)
        {
            this.lineSpacing = lineSpacing;
            return this;
        }

        public Builder SetTextAlign(int textAlign)
        {
            this.textAlign = textAlign;
            return this;
        }

        public Builder SetIsBold(bool isBold)
        {
            this.isBold = isBold;
            return this;
        }

        public Builder SetIsItalic(bool isItalic)
        {
            this.isItalic = isItalic;
            return this;
        }

        public Builder SetIsMultipleLine(bool isMultipleLine)
        {
            this.isMultipleLine = isMultipleLine;
            return this;
        }


        public iLCheckOverflowConfig build()
        {
            return new iLCheckOverflowConfig(pageId, stringId, stringRealContent, designWidth, designHeight, measuredWidth, measuredHeight, fontFamily, fontSize, lineSpacing, textAlign, isBold, isItalic, isMultipleLine);
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
    public string GetFontFamily()
    {
        return fontFamily;
    }
    public float GetFontSize()
    {
        return fontSize;
    }
    public float GetLineSpacing()
    {
        return lineSpacing;
    }
    public int GetTextAlign()
    {
        return textAlign;
    }
    public bool GetIsBold()
    {
        return isBold;
    }
    public bool GetIsItalic()
    {
        return isItalic;
    }
    public bool GetIsMultipleLine()
    {
        return isMultipleLine;
    }

    private iLCheckOverflowConfig(string pageId, string stringId, string stringRealContent, float designWidth, float designHeight, float measuredWidth, float measuredHeight, string fontFamily, float fontSize, float lineSpacing, int textAlign, bool isBold, bool isItalic, bool isMultipleLine)
    {
        this.pageId = pageId;
        this.stringId = stringId;
        this.stringRealContent = stringRealContent;
        this.designWidth = designWidth;
        this.designHeight = designHeight;
        this.measuredWidth = measuredWidth;
        this.measuredHeight = measuredHeight;
        this.fontFamily = fontFamily;
        this.fontSize = fontSize;
        this.lineSpacing = lineSpacing;
        this.textAlign = textAlign;
        this.isBold = isBold;
        this.isItalic = isItalic;
        this.isMultipleLine = isMultipleLine;
    }

}
