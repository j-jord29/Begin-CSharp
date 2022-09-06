using SnapsLibrary;
using System;

public class MusicNotes
{
    public void StartProgram()
    {
        SnapsEngine.SetTitleString("Music Box");
        /*
        int [] notePitches = new int[3];
        double[] noteDurations = new double[3];

        notePitches[0] = 0;
        notePitches[1] = 2;
        notePitches[2] = 4;

        noteDurations[0] = 0.4;
        noteDurations[1] = 0.8;
        noteDurations[2] = 0.4;

        for (int i = 0; i < 3; i++)
        {
            SnapsEngine.PlayNote(pitch: notePitches[i], duration: noteDurations[i]);
        } 
        */
        SongNotes[] tune = new SongNotes[100];

        int tuneLength = 0;

        for (int tunePos = 0; tunePos < tune.Length; tunePos++)
        {
            string command = SnapsEngine.SelectFrom2Buttons("New Note", "Play Tune");

            if(command == "Play Tune")
            {
                tuneLength = tunePos;
                break;
            }

            int notePitch = SnapsEngine.ReadInteger("Note Pitch");
            float noteDuration = SnapsEngine.ReadFloat("Note Duration");

            SongNotes newNote = new SongNotes(notePitch, noteDuration);

            tune[tunePos] = newNote;           
        }

        for (int tunePos = 0; tunePos < tuneLength; tunePos++)
        {
            SnapsEngine.PlayNote(pitch: tune[tunePos].NotePitch, duration: tune[tunePos].NoteDuration);
        }

    }

    public struct SongNotes
    {
        public int NotePitch;
        public double NoteDuration;

        public SongNotes(int pitch, double duration)
        {
            if (pitch < 0 || pitch > 12)
            {
                throw new Exception("Invalid Note Pitch");
            }

            if (duration < 0.1 || duration > 12)
            {
                throw new Exception("Invalid Note Duration");
            }
            NotePitch = pitch;
            NoteDuration = duration;
            SnapsEngine.DisplayString("Hello From The Piano");
        }
    }

}


