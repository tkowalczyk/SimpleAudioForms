using System;

namespace SimpleAudioForms
{
	public interface IAudio
	{
		bool PlayMp3File(string fileName);
		bool PlayWavFile(string fileName);
	}
}