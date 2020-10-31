
public class iLocalizeUserConfig {

    private string userTags;

    public class Builder {
        private string userTags = "";

        public Builder SetUserTags(string userTags) {
            this.userTags = userTags;
            return this;
        }

        public iLocalizeUserConfig build() {
            return new iLocalizeUserConfig(userTags);
        }

    }

    public string GetUserTags() {
        return userTags;
    }

    private iLocalizeUserConfig(string userTags) {
        this.userTags = userTags;
    }

}
