namespace WpfMid_Prototype.Database
{
    class Instruction
    {
        string mediaPath; // path for the uploaded media (pics/video)
        string instructions; // the instructions proper
        int timerTime; // duration of time for this steps timer (if applicable)

        Instruction(string path, string instr, int time)
        {
            this.mediaPath = path;
            this.instructions = instr;
            this.timerTime = time;
        }

        ~Instruction() { }
    }
}
