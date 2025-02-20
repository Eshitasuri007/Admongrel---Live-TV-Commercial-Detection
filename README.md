******Commercial Break Detection in Live Television Streams******

****Overview****

With the rise of digital media consumption, broadcasters and advertisers face increasing challenges in real-time content segmentation. This project applies machine learning techniques to detect commercial breaks in live Turkish television streams, addressing the erratic break patterns characteristic of Turkish TV shows.
By leveraging Convolutional Neural Networks (CNNs) and Support Vector Machines (SVMs), this research enhances real-time broadcast monitoring and contributes to advancements in media analytics.

****Project Workflow****

**Data Collection & Preprocessing**
A continuous video stream from Turkish TV channels is recorded.
C# and FFmpeg are used to extract frames at a specified rate.
Frames are manually categorized into 'commercials' and 'show' subsets.
Rigorous data cleaning removes duplicates and corrupted files.

**Feature Engineering & Model Selection**
Comprehensive data exploration reveals key patterns within the frames.
Machine learning models are trained to distinguish commercials from TV shows.

**Models evaluated include:**
Convolutional Neural Networks (CNNs)
Support Vector Machines (SVMs)

**Performance Evaluation**
The models are assessed using:
Precision
Recall
F1 Score
The methodology demonstrates high accuracy in identifying commercial breaks.


****Technologies Used****
Programming Languages: Python, C#
Libraries & Frameworks: OpenCV, TensorFlow/Keras, Scikit-learn
Tools: FFmpeg for frame extraction, Manual annotation tools for labeling



Contributors
👤 Eshita Suri
