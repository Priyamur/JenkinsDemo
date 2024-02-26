namespace JenkinsDemo
{
    public class TestMe
    {
        public String? sayJenkins(int times)
        {
            String Output = "";
            for(int i=0;i<times;i++)
            {
                Output += "Jenkins";
            }
            return Output;
        }
    }
}
