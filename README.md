# Learn-Sounds-Easy
An educational application to help students in Ghana learn letter sounds easily.
diff --git a/README.md b/README.md
--- a/README.md
+++ b/README.md

+# Ghana Letter Sounds App 🇬🇭
+
+A mobile application designed to help Ghanaian students learn letter sounds through fun, interactive activities using familiar words and cultural references.
+
+## Features
+
+### 🎯 Core Learning Activities
+- **Letter Sounds Learning**: Interactive cards with Ghanaian-contextualized examples
+- **Word Building**: Drag-and-drop letter activities using cultural words
+- **Sentence Construction**: Build meaningful sentences with Ghanaian context
+- **Fun Games**: Letter matching, word puzzles, and sound recognition games
+- **Progress Tracking**: Comprehensive progress monitoring with achievements
+
+### 🇬🇭 Ghanaian Cultural Integration
+- **Local Examples**: Letters taught using familiar Ghanaian words (Banku, Adinkra, Accra, etc.)
+- **Cultural Categories**: Food, Places, Names, and Traditions
+- **Twi Phrases**: Common Ghanaian greetings and expressions with pronunciation
+- **Encouragement Messages**: Motivational messages in local context
+
+### 📱 User-Friendly Design
+- **Colorful Interface**: Engaging design suitable for children
+- **Audio Support**: Sound feedback for letter pronunciation
+- **Animation**: Smooth transitions and interactive feedback
+- **Progress Tracking**: Visual progress bars and achievement badges
+
+## App Structure
+
+```
+src/
+├── data/
+│   └── ghanaianContent.js      # Cultural content and letter data
+├── screens/
+│   ├── HomeScreen.js           # Welcome screen with navigation
+│   ├── LetterSoundsScreen.js   # Interactive letter learning
+│   ├── WordBuilderScreen.js    # Word formation activities
+│   ├── SentenceBuilderScreen.js # Sentence building exercises
+│   ├── GamesScreen.js          # Educational games
+│   └── ProgressScreen.js       # Progress tracking and achievements
+└── App.js                      # Main navigation and app structure
+```
+
+## Technology Stack
+
+- **React Native 0.72.6**: Cross-platform mobile framework
+- **React Navigation 6**: Navigation between screens
+- **React Native Vector Icons**: Material Design icons
+- **React Native Linear Gradient**: Beautiful gradient backgrounds
+- **React Native Reanimated**: Smooth animations
+- **React Native Async Storage**: Local data persistence
+
+## Installation & Setup
+
+### Prerequisites
+- Node.js (v16 or higher)
+- React Native CLI
+- Android Studio (for Android development)
+- Xcode (for iOS development, macOS only)
+
+### Install Dependencies
+```bash
+npm install
+```
+
+### Android Setup
+```bash
+# Run on Android device/emulator
+npm run android
+```
+
+### iOS Setup
+```bash
+# Install iOS dependencies
+cd ios && pod install && cd ..
+
+# Run on iOS device/simulator
+npm run ios
+```
+
+## Educational Content
+
+### Letters Covered
+The app includes comprehensive coverage of the English alphabet with Ghanaian examples:
+- **A**: Ama, Accra, Adinkra
+- **B**: Banku, Baobab, Beads
+- **C**: Cedi, Cocoa, Cape Coast
+- **D**: Drumming, Damba, Donkey
+- **And more...**
+
+### Cultural Word Categories
+- **Family**: Mama, Papa, Sister, Brother, Baby
+- **Food**: Banku, Fufu, Jollof, Kenkey, Waakye
+- **Places**: Accra, Kumasi, Tamale, School, Market
+- **Animals**: Elephant, Monkey, Bird, Fish, Goat
+- **Colors**: Red, Yellow, Green, Blue, Black
+
+### Twi Integration
+Common Ghanaian phrases with pronunciation:
+- "Maakye" (Good morning)
+- "Medaase" (Thank you)
+- "Wo ho te sɛn?" (How are you?)
+
+## App Screens
+
+### 1. Home Screen (Akwaaba Home)
+- Welcome message with rotating greetings
+- Feature navigation cards
+- Cultural context introduction
+
+### 2. Letter Sounds
+- Interactive letter cards with colors
+- Audio pronunciation
+- Ghanaian word examples
+- Practice activities
+
+### 3. Word Builder
+- Category-based word selection
+- Drag-and-drop letter assembly
+- Progress tracking
+- Success celebrations
+
+### 4. Sentence Builder
+- Template-based sentence construction
+- Progressive difficulty levels
+- Cultural phrase learning
+- Hint system
+
+### 5. Games
+- Letter Sound Match
+- Ghanaian Word Puzzle
+- Sound Detective (coming soon)
+- Speed Match (coming soon)
+
+### 6. Progress Tracking
+- Learning statistics
+- Achievement badges
+- Weekly activity charts
+- Detailed progress analytics
+
+## Features for Future Development
+
+### Enhanced Audio
+- Native speaker recordings
+- Twi language narration
+- Background music with Ghanaian themes
+
+### Additional Content
+- More cultural words and phrases
+- Advanced sentence patterns
+- Regional dialect variations
+- Cultural stories and folk tales
+
+### Gamification
+- More interactive games
+- Multiplayer challenges
+- Leaderboards
+- Social sharing features
+
+## Contributing
+
+This app was created as part of an educational initiative to support Ghanaian students' literacy development. Contributions are welcome to expand the cultural content and improve the learning experience.
+
+### Areas for Contribution
+- Additional Ghanaian cultural words and contexts
+- Audio recordings by native speakers
+- Enhanced game mechanics
+- Accessibility improvements
+- Performance optimizations
+
+## License
+
+MIT License - Feel free to use and modify for educational purposes.
+
+## Contact
+
+**Developer**: AMOAH PETER ATUAH  
+**Email**: amoahpeter7788@gmail.com  
+**Phone**: 0554666872  
+
+
+---
+
+*Wo yɛ adeɛ! (You are amazing!) - Keep learning and growing!* 🌟


diff --git a/android/app/build.gradle b/android/app/build.gradle
--- a/android/app/build.gradle
+++ b/android/app/build.gradle
@@ -0,0 +1,47 @@
+apply plugin: "com.android.application"
+apply plugin: "com.facebook.react"
+
+react {
+    debuggingEnabled = false
+}
+
+android {
+    compileSdkVersion rootProject.ext.compileSdkVersion
+
+    defaultConfig {
+        applicationId "com.ghanalettersondsapp"
+        minSdkVersion rootProject.ext.minSdkVersion
+        targetSdkVersion rootProject.ext.targetSdkVersion
+        versionCode 1
+        versionName "1.0"
+        buildConfigField "boolean", "IS_NEW_ARCHITECTURE_ENABLED", isNewArchitectureEnabled().toString()
+        buildConfigField "boolean", "IS_HERMES_ENABLED", (findProperty("react.enableHermes") ?: true).toString()
+    }
+    
+    buildTypes {
+        debug {
+            signingConfig signingConfigs.debug
+        }
+        release {
+            signingConfig signingConfigs.debug
+            minifyEnabled enableProguardInReleaseBuilds
+            proguardFiles getDefaultProguardFile("proguard-android.txt"), "proguard-rules.pro"
+        }
+    }
+}
+
+dependencies {
+    implementation "com.facebook.react:react-android"
+    implementation "androidx.swiperefreshlayout:swiperefreshlayout:1.0.0"
+    debugImplementation("com.facebook.flipper:flipper:${FLIPPER_VERSION}")
+    debugImplementation("com.facebook.flipper:flipper-network-plugin:${FLIPPER_VERSION}") {
+        exclude group:'com.squareup.okhttp3', module:'okhttp'
+    }
+    debugImplementation("com.facebook.flipper:flipper-fresco-plugin:${FLIPPER_VERSION}")
+
+    if (hermesEnabled.toBoolean()) {
+        implementation("com.facebook.react:hermes-android")
+    } else {
+        implementation jscFlavor
+    }

+}
diff --git a/android/app/src/main/AndroidManifest.xml b/android/app/src/main/AndroidManifest.xml
--- a/android/app/src/main/AndroidManifest.xml
+++ b/android/app/src/main/AndroidManifest.xml
@@ -0,0 +1,27 @@
+<manifest xmlns:android="http://schemas.android.com/apk/res/android">
+
+    <uses-permission android:name="android.permission.INTERNET" />
+    <uses-permission android:name="android.permission.RECORD_AUDIO" />
+    <uses-permission android:name="android.permission.WAKE_LOCK" />
+
+    <application
+      android:name=".MainApplication"
+      android:label="@string/app_name"
+      android:icon="@mipmap/ic_launcher"
+      android:roundIcon="@mipmap/ic_launcher_round"
+      android:allowBackup="false"
+      android:theme="@style/AppTheme">
+      <activity
+        android:name=".MainActivity"
+        android:label="@string/app_name"
+        android:configChanges="keyboard|keyboardHidden|orientation|screenLayout|screenSize|smallestScreenSize|uiMode"
+        android:launchMode="singleTask"
+        android:windowSoftInputMode="adjustResize"
+        android:exported="true">
+        <intent-filter>
+            <action android:name="android.intent.action.MAIN" />
+            <category android:name="android.intent.category.LAUNCHER" />
+        </intent-filter>
+      </activity>
+    </application>
+</manifest> 

diff --git a/android/app/src/main/java/com/ghanalettersondsapp/MainApplication.java b/android/app/src/main/java/com/ghanalettersondsapp/MainApplication.java
--- a/android/app/src/main/java/com/ghanalettersondsapp/MainApplication.java
+++ b/android/app/src/main/java/com/ghanalettersondsapp/MainApplication.java
@@ -0,0 +1,68 @@
+package com.ghanalettersondsapp;
+
+import android.app.Application;
+import com.facebook.react.PackageList;
+import com.facebook.react.ReactApplication;
+import com.facebook.react.ReactHost;
+import com.facebook.react.ReactNativeHost;
+import com.facebook.react.ReactPackage;
+import com.facebook.react.defaults.DefaultNewArchitectureEntryPoint;
+import com.facebook.react.defaults.DefaultReactHost;
+import com.facebook.react.defaults.DefaultReactNativeHost;
+import com.facebook.soloader.SoLoader;
+import java.util.List;
+
+public class MainApplication extends Application implements ReactApplication {
+
+  private final ReactNativeHost mReactNativeHost =
+      new DefaultReactNativeHost(this) {
+        @Override
+        public boolean getUseDeveloperSupport() {
+          return BuildConfig.DEBUG;
+        }
+
+        @Override
+        protected List<ReactPackage> getPackages() {
+          @SuppressWarnings("UnnecessaryLocalVariable")
+          List<ReactPackage> packages = new PackageList(this).getPackages();
+          // Packages that cannot be autolinked yet can be added manually here, for example:
+          // packages.add(new MyReactNativePackage());
+          return packages;
+        }
+
+        @Override
+        protected String getJSMainModuleName() {
+          return "index";
+        }
+
+        @Override
+        protected boolean isNewArchEnabled() {
+          return BuildConfig.IS_NEW_ARCHITECTURE_ENABLED;
+        }
+
+        @Override
+        protected Boolean isHermesEnabled() {
+          return BuildConfig.IS_HERMES_ENABLED;
+        }
+      };
+
+  @Override
+  public ReactNativeHost getReactNativeHost() {
+    return mReactNativeHost;
+  }
+
+  @Override
+  public ReactHost getReactHost() {
+    return DefaultReactHost.getDefaultReactHost(this.getApplicationContext(), getReactNativeHost());
+  }
+
+  @Override
+  public void onCreate() {
+    super.onCreate();
+    SoLoader.init(this, /* native exopackage */ false);
+    if (BuildConfig.IS_NEW_ARCHITECTURE_ENABLED) {
+      // If you opted-in for the New Architecture, we load the native entry point for this app.
+      DefaultNewArchitectureEntryPoint.load();
+    }
+  }

+} 
diff --git a/android/app/src/main/res/values/strings.xml b/android/app/src/main/res/values/strings.xml
--- a/android/app/src/main/res/values/strings.xml
+++ b/android/app/src/main/res/values/strings.xml
@@ -0,0 +1,3 @@
+<resources>
+    <string name="app_name">Ghana Letter Sounds</string>
+</resources>
diff --git a/babel.config.js b/babel.config.js
--- a/babel.config.js
+++ b/babel.config.js
@@ -0,0 +1,6 @@
+module.exports = {
+  presets: ['module:metro-react-native-babel-preset'],
+  plugins: [
+    'react-native-reanimated/plugin',
+  ],

+};  

diff --git a/index.js b/index.js
--- a/index.js
+++ b/index.js
@@ -0,0 +1,5 @@
+import {AppRegistry} from 'react-native';
+import App from './App';
+import {name as appName} from './package.json';
+
+AppRegistry.registerComponent(appName, () => App);  

diff --git a/metro.config.js b/metro.config.js
--- a/metro.config.js
+++ b/metro.config.js
@@ -0,0 +1,11 @@
+const {getDefaultConfig, mergeConfig} = require('@react-native/metro-config');
+
+/**
+ * Metro configuration
+ * https://facebook.github.io/metro/docs/configuration
+ *
+ * @type {import('metro-config').MetroConfig}
+ */
+const config = {};
+
+module.exports = mergeConfig(getDefaultConfig(__dirname), config);   

diff --git a/package.json b/package.json
--- a/package.json
+++ b/package.json
@@ -0,0 +1,53 @@
+{
+  "name": "ghana-letter-sounds-app",
+  "version": "1.0.0",
+  "description": "A mobile application to help Ghanaian students learn letter sounds and build words",
+  "main": "index.js",
+  "scripts": {
+    "android": "react-native run-android",
+    "ios": "react-native run-ios",
+    "start": "react-native start",
+    "test": "jest",
+    "lint": "eslint .",
+    "build": "react-native bundle --platform android --dev false --entry-file index.js --bundle-output android/app/src/main/assets/index.android.bundle"
+  },
+  "dependencies": {
+    "react": "18.2.0",
+    "react-native": "0.72.6",
+    "react-native-sound": "^0.11.2",
+    "react-native-vector-icons": "^10.0.0",
+    "react-navigation": "^6.0.0",
+    "@react-navigation/native": "^6.1.9",
+    "@react-navigation/stack": "^6.3.20",
+    "@react-navigation/bottom-tabs": "^6.5.11",
+    "react-native-screens": "^3.27.0",
+    "react-native-safe-area-context": "^4.7.4",
+    "react-native-gesture-handler": "^2.13.4",
+    "react-native-reanimated": "^3.5.4",
+    "react-native-svg": "^13.14.0",
+    "react-native-linear-gradient": "^2.8.3",
+    "react-native-async-storage": "^1.19.3"
+  },
+  "devDependencies": {
+    "@babel/core": "^7.20.0",
+    "@babel/preset-env": "^7.20.0",
+    "@babel/runtime": "^7.20.0",
+    "@react-native/eslint-config": "^0.72.2",
+    "@react-native/metro-config": "^0.72.11",
+    "@tsconfig/react-native": "^3.0.0",
+    "@types/react": "^18.0.24",
+    "@types/react-test-renderer": "^18.0.0",
+    "babel-jest": "^29.2.1",
+    "eslint": "^8.19.0",
+    "jest": "^29.2.1",
+    "metro-react-native-babel-preset": "0.76.8",
+    "prettier": "^2.4.1",
+    "react-test-renderer": "18.2.0",
+    "typescript": "4.8.4"
+  },
+  "jest": {
+    "preset": "react-native"
+  },
+  "author": "AMOAH PETER ATUAH",
+  "license": "MIT"

+}  

diff --git a/setup.sh b/setup.sh
--- a/setup.sh
+++ b/setup.sh
@@ -0,0 +1,57 @@
+#!/bin/bash
+
+# Ghana Letter Sounds App Setup Script
+
+echo "🇬🇭 Setting up Ghana Letter Sounds App..."
+echo "============================================="
+
+# Check if Node.js is installed
+if ! command -v node &> /dev/null; then
+    echo "❌ Node.js is not installed. Please install Node.js (v16 or higher) first."
+    exit 1
+fi
+
+echo "✅ Node.js version: $(node --version)"
+
+# Check if npm is available
+if ! command -v npm &> /dev/null; then
+    echo "❌ npm is not available. Please install npm."
+    exit 1
+fi
+
+echo "✅ npm version: $(npm --version)"
+
+# Install dependencies
+echo "📦 Installing dependencies..."
+npm install
+
+if [ $? -eq 0 ]; then
+    echo "✅ Dependencies installed successfully!"
+else
+    echo "❌ Failed to install dependencies. Please check your internet connection and try again."
+    exit 1
+fi
+
+# Check if React Native CLI is installed
+if ! command -v react-native &> /dev/null; then
+    echo "⚠️  React Native CLI is not installed globally."
+    echo "📥 Installing React Native CLI..."
+    npm install -g react-native-cli
+fi
+
+echo ""
+echo "🎉 Setup completed successfully!"
+echo ""
+echo "To run the app:"
+echo "==============="
+echo "For Android:"
+echo "  npm run android"
+echo ""
+echo "For iOS (macOS only):"
+echo "  cd ios && pod install && cd .."
+echo "  npm run ios"
+echo ""
+echo "To start the Metro bundler:"
+echo "  npm start"
+echo ""
+echo "Akwaaba! Welcome to Ghana Letter Sounds! 🇬🇭"  

diff --git a/src/data/ghanaianContent.js b/src/data/ghanaianContent.js
--- a/src/data/ghanaianContent.js
+++ b/src/data/ghanaianContent.js
@@ -0,0 +1,134 @@
+// Ghanaian-contextualized content for letter sounds learning
+
+export const letters = [
+  {
+    letter: 'A',
+    sound: '/æ/',
+    examples: [
+      {word: 'Ama', meaning: 'A popular Ghanaian female name', image: 'girl'},
+      {word: 'Accra', meaning: 'Capital city of Ghana', image: 'city'},
+      {word: 'Adinkra', meaning: 'Traditional Ghanaian symbols', image: 'symbol'},
+    ],
+    color: '#FF6B35'
+  },
+  {
+    letter: 'B',
+    sound: '/b/',
+    examples: [
+      {word: 'Banku', meaning: 'Traditional Ghanaian food', image: 'food'},
+      {word: 'Baobab', meaning: 'Big tree found in Northern Ghana', image: 'tree'},
+      {word: 'Beads', meaning: 'Beautiful African jewelry', image: 'beads'},
+    ],
+    color: '#4ECDC4'
+  },
+  {
+    letter: 'C',
+    sound: '/k/',
+    examples: [
+      {word: 'Cedi', meaning: 'Ghana\'s currency', image: 'money'},
+      {word: 'Cocoa', meaning: 'Ghana\'s famous crop', image: 'cocoa'},
+      {word: 'Cape Coast', meaning: 'Historic city in Ghana', image: 'castle'},
+    ],
+    color: '#45B7D1'
+  },
+  {
+    letter: 'D',
+    sound: '/d/',
+    examples: [
+      {word: 'Drumming', meaning: 'Traditional Ghanaian music', image: 'drum'},
+      {word: 'Damba', meaning: 'Northern Ghana festival', image: 'festival'},
+      {word: 'Donkey', meaning: 'Animal used for transport', image: 'donkey'},
+    ],
+    color: '#96CEB4'
+  },
+  {
+    letter: 'E',
+    sound: '/e/',
+    examples: [
+      {word: 'Eba', meaning: 'Food made from cassava', image: 'food'},
+      {word: 'Eagle', meaning: 'Bird on Ghana\'s coat of arms', image: 'eagle'},
+      {word: 'Elephant', meaning: 'Big animal in Mole National Park', image: 'elephant'},
+    ],
+    color: '#FFEAA7'
+  },
+  {
+    letter: 'F',
+    sound: '/f/',
+    examples: [
+      {word: 'Fufu', meaning: 'Popular Ghanaian dish', image: 'fufu'},
+      {word: 'Fan milk', meaning: 'Popular ice cream in Ghana', image: 'icecream'},
+      {word: 'Fish', meaning: 'Common protein in coastal Ghana', image: 'fish'},
+    ],
+    color: '#DDA0DD'
+  },
+  {
+    letter: 'G',
+    sound: '/g/',
+    examples: [
+      {word: 'Ghana', meaning: 'Our beautiful country', image: 'flag'},
+      {word: 'Gari', meaning: 'Food made from cassava', image: 'gari'},
+      {word: 'Gold', meaning: 'Precious metal Ghana is known for', image: 'gold'},
+    ],
+    color: '#FFD93D'
+  },
+  {
+    letter: 'H',
+    sound: '/h/',
+    examples: [
+      {word: 'Harmattan', meaning: 'Dry season wind in Ghana', image: 'wind'},
+      {word: 'Hippo', meaning: 'Animal found in River Volta', image: 'hippo'},
+      {word: 'Hut', meaning: 'Traditional round house', image: 'hut'},
+    ],
+    color: '#FF7675'
+  },
+  {
+    letter: 'I',
+    sound: '/i/',
+    examples: [
+      {word: 'Independence', meaning: 'Ghana gained freedom in 1957', image: 'independence'},
+      {word: 'Iguana', meaning: 'Lizard found in Ghana', image: 'iguana'},
+      {word: 'Island', meaning: 'Land surrounded by water', image: 'island'},
+    ],
+    color: '#A29BFE'
+  },
+  {
+    letter: 'J',
+    sound: '/dʒ/',
+    examples: [
+      {word: 'Jollof', meaning: 'Popular rice dish', image: 'jollof'},
+      {word: 'Jungle', meaning: 'Dense forest like Kakum', image: 'jungle'},
+      {word: 'Jewelry', meaning: 'Beautiful ornaments', image: 'jewelry'},
+    ],
+    color: '#6C5CE7'
+  }
+];
+
+export const culturalWords = [
+  {category: 'Family', words: ['Mama', 'Papa', 'Sister', 'Brother', 'Baby']},
+  {category: 'Food', words: ['Banku', 'Fufu', 'Jollof', 'Kenkey', 'Waakye']},
+  {category: 'Places', words: ['Accra', 'Kumasi', 'Tamale', 'School', 'Market']},
+  {category: 'Animals', words: ['Elephant', 'Monkey', 'Bird', 'Fish', 'Goat']},
+  {category: 'Colors', words: ['Red', 'Yellow', 'Green', 'Blue', 'Black']},
+];
+
+export const ghanaianNames = [
+  'Kofi', 'Ama', 'Kwame', 'Akosua', 'Yaw', 'Adwoa', 'Kofi', 'Efua',
+  'Kwaku', 'Aba', 'Yaw', 'Akua', 'Fiifi', 'Maame', 'Kojo', 'Esi'
+];
+
+export const commonPhrases = [
+  {english: 'Good morning', twi: 'Maakye', pronunciation: 'MAH-cheh'},
+  {english: 'Thank you', twi: 'Medaase', pronunciation: 'meh-DAH-seh'},
+  {english: 'How are you?', twi: 'Wo ho te sɛn?', pronunciation: 'wo ho teh sen'},
+  {english: 'I am fine', twi: 'Me ho yɛ', pronunciation: 'meh ho yeh'},
+  {english: 'What is your name?', twi: 'Wo din de sɛn?', pronunciation: 'wo din deh sen'},
+];
+
+export const encouragementMessages = [
+  'Ayɛ! You are doing great!',
+  'Wo yɛ adeɛ! You are amazing!',
+  'Keep going, champion!',
+  'You make Ghana proud!',
+  'Excellent work, my friend!',
+  'You are a star student!',

+]; 

diff --git a/src/screens/GamesScreen.js b/src/screens/GamesScreen.js
--- a/src/screens/GamesScreen.js
+++ b/src/screens/GamesScreen.js
@@ -0,0 +1,613 @@
+import React, {useState, useRef, useEffect} from 'react';
+import {
+  View,
+  Text,
+  StyleSheet,
+  ScrollView,
+  TouchableOpacity,
+  Animated,
+  Alert,
+} from 'react-native';
+import Icon from 'react-native-vector-icons/MaterialIcons';
+import {
+  letters,
+  culturalWords,
+  ghanaianNames,
+  encouragementMessages,
+} from '../data/ghanaianContent';
+
+const GamesScreen = () => {
+  const [currentGame, setCurrentGame] = useState('menu');
+  const [score, setScore] = useState(0);
+  const [gameData, setGameData] = useState({});
+  const animatedValue = useRef(new Animated.Value(0)).current;
+
+  const games = [
+    {
+      id: 'letterMatch',
+      title: 'Letter Sound Match',
+      description: 'Match letters with their sounds',
+      icon: 'hearing',
+      color: '#FF6B35',
+    },
+    {
+      id: 'wordPuzzle',
+      title: 'Ghanaian Word Puzzle',
+      description: 'Find the missing letters in Ghanaian words',
+      icon: 'extension',
+      color: '#4ECDC4',
+    },
+    {
+      id: 'soundGuess',
+      title: 'Sound Detective',
+      description: 'Guess the letter from its sound',
+      icon: 'search',
+      color: '#45B7D1',
+    },
+    {
+      id: 'speedMatch',
+      title: 'Speed Match',
+      description: 'Quick letter and word matching',
+      icon: 'flash-on',
+      color: '#96CEB4',
+    },
+  ];
+
+  // Letter Sound Match Game
+  const [letterMatchData, setLetterMatchData] = useState({
+    currentLetter: null,
+    options: [],
+    correctAnswers: 0,
+  });
+
+  // Word Puzzle Game
+  const [wordPuzzleData, setWordPuzzleData] = useState({
+    currentWord: '',
+    hiddenLetters: [],
+    guessedLetters: [],
+    attempts: 0,
+  });
+
+  // Sound Detective Game
+  const [soundDetectiveData, setSoundDetectiveData] = useState({
+    currentSound: '',
+    letterOptions: [],
+    streak: 0,
+  });
+
+  // Speed Match Game
+  const [speedMatchData, setSpeedMatchData] = useState({
+    timeLeft: 30,
+    pairs: [],
+    matchedPairs: [],
+    selectedCard: null,
+  });
+
+  useEffect(() => {
+    if (currentGame === 'letterMatch') {
+      initializeLetterMatch();
+    } else if (currentGame === 'wordPuzzle') {
+      initializeWordPuzzle();
+    } else if (currentGame === 'soundGuess') {
+      initializeSoundDetective();
+    } else if (currentGame === 'speedMatch') {
+      initializeSpeedMatch();
+    }
+  }, [currentGame]);
+
+  const initializeLetterMatch = () => {
+    const randomLetter = letters[Math.floor(Math.random() * letters.length)];
+    const wrongOptions = letters
+      .filter(l => l.letter !== randomLetter.letter)
+      .slice(0, 2)
+      .map(l => l.sound);
+    
+    const options = [randomLetter.sound, ...wrongOptions].sort(() => Math.random() - 0.5);
+    
+    setLetterMatchData({
+      currentLetter: randomLetter,
+      options,
+      correctAnswers: 0,
+    });
+  };
+
+  const initializeWordPuzzle = () => {
+    const allWords = culturalWords.flatMap(cat => cat.words);
+    const randomWord = allWords[Math.floor(Math.random() * allWords.length)];
+    const wordLetters = randomWord.toUpperCase().split('');
+    
+    // Hide 1-2 letters randomly
+    const hideCount = Math.min(2, Math.max(1, Math.floor(wordLetters.length / 3)));
+    const hiddenIndices = [];
+    
+    while (hiddenIndices.length < hideCount) {
+      const randomIndex = Math.floor(Math.random() * wordLetters.length);
+      if (!hiddenIndices.includes(randomIndex)) {
+        hiddenIndices.push(randomIndex);
+      }
+    }
+    
+    setWordPuzzleData({
+      currentWord: randomWord,
+      hiddenLetters: hiddenIndices,
+      guessedLetters: new Array(wordLetters.length).fill(''),
+      attempts: 0,
+    });
+  };
+
+  const initializeSoundDetective = () => {
+    const randomLetter = letters[Math.floor(Math.random() * letters.length)];
+    const wrongLetters = letters
+      .filter(l => l.letter !== randomLetter.letter)
+      .slice(0, 3)
+      .map(l => l.letter);
+    
+    const letterOptions = [randomLetter.letter, ...wrongLetters].sort(() => Math.random() - 0.5);
+    
+    setSoundDetectiveData({
+      currentSound: randomLetter.sound,
+      letterOptions,
+      streak: 0,
+    });
+  };
+
+  const initializeSpeedMatch = () => {
+    const gameLetters = letters.slice(0, 6);
+    const pairs = [];
+    
+    gameLetters.forEach(letter => {
+      pairs.push({type: 'letter', value: letter.letter, id: letter.letter + '_letter'});
+      pairs.push({type: 'sound', value: letter.sound, id: letter.letter + '_sound'});
+    });
+    
+    const shuffledPairs = pairs.sort(() => Math.random() - 0.5);
+    
+    setSpeedMatchData({
+      timeLeft: 30,
+      pairs: shuffledPairs,
+      matchedPairs: [],
+      selectedCard: null,
+    });
+  };
+
+  const playSuccessAnimation = () => {
+    Animated.sequence([
+      Animated.timing(animatedValue, {
+        toValue: 1,
+        duration: 200,
+        useNativeDriver: true,
+      }),
+      Animated.timing(animatedValue, {
+        toValue: 0,
+        duration: 200,
+        useNativeDriver: true,
+      }),
+    ]).start();
+  };
+
+  const showEncouragement = (isCorrect = true) => {
+    const message = isCorrect 
+      ? encouragementMessages[Math.floor(Math.random() * encouragementMessages.length)]
+      : 'Try again! You\'re doing great!';
+    
+    Alert.alert(
+      isCorrect ? 'Ayɛ! Correct! 🎉' : 'Keep trying! 💪',
+      message,
+      [{text: 'Continue'}]
+    );
+  };
+
+  const GameMenu = () => (
+    <View style={styles.gameMenuContainer}>
+      <Text style={styles.gameMenuTitle}>Choose a Fun Game!</Text>
+      <Text style={styles.currentScore}>Current Score: {score} points</Text>
+      
+      <View style={styles.gamesGrid}>
+        {games.map((game) => (
+          <TouchableOpacity
+            key={game.id}
+            style={[styles.gameCard, {borderLeftColor: game.color}]}
+            onPress={() => setCurrentGame(game.id)}>
+            <View style={[styles.gameIcon, {backgroundColor: game.color}]}>
+              <Icon name={game.icon} size={30} color="#FFF" />
+            </View>
+            <View style={styles.gameInfo}>
+              <Text style={styles.gameTitle}>{game.title}</Text>
+              <Text style={styles.gameDescription}>{game.description}</Text>
+            </View>
+            <Icon name="play-arrow" size={24} color={game.color} />
+          </TouchableOpacity>
+        ))}
+      </View>
+    </View>
+  );
+
+  const LetterMatchGame = () => (
+    <View style={styles.gameContainer}>
+      <View style={styles.gameHeader}>
+        <TouchableOpacity onPress={() => setCurrentGame('menu')}>
+          <Icon name="arrow-back" size={24} color="#FFF" />
+        </TouchableOpacity>
+        <Text style={styles.gameHeaderTitle}>Letter Sound Match</Text>
+        <Text style={styles.gameScore}>{score}pts</Text>
+      </View>
+
+      <View style={styles.gameContent}>
+        <Text style={styles.gameQuestion}>Which sound does this letter make?</Text>
+        
+        <Animated.View
+          style={[
+            styles.letterCard,
+            {
+              backgroundColor: letterMatchData.currentLetter?.color,
+              transform: [
+                {
+                  scale: animatedValue.interpolate({
+                    inputRange: [0, 1],
+                    outputRange: [1, 1.2],
+                  }),
+                },
+              ],
+            },
+          ]}>
+          <Text style={styles.letterCardText}>
+            {letterMatchData.currentLetter?.letter}
+          </Text>
+        </Animated.View>
+
+        <View style={styles.optionsContainer}>
+          {letterMatchData.options.map((option, index) => (
+            <TouchableOpacity
+              key={index}
+              style={styles.optionButton}
+              onPress={() => {
+                const isCorrect = option === letterMatchData.currentLetter.sound;
+                if (isCorrect) {
+                  setScore(score + 10);
+                  playSuccessAnimation();
+                  showEncouragement(true);
+                  setTimeout(initializeLetterMatch, 1000);
+                } else {
+                  showEncouragement(false);
+                }
+              }}>
+              <Text style={styles.optionText}>{option}</Text>
+            </TouchableOpacity>
+          ))}
+        </View>
+      </View>
+    </View>
+  );
+
+  const WordPuzzleGame = () => {
+    const wordLetters = wordPuzzleData.currentWord.toUpperCase().split('');
+    
+    return (
+      <View style={styles.gameContainer}>
+        <View style={styles.gameHeader}>
+          <TouchableOpacity onPress={() => setCurrentGame('menu')}>
+            <Icon name="arrow-back" size={24} color="#FFF" />
+          </TouchableOpacity>
+          <Text style={styles.gameHeaderTitle}>Word Puzzle</Text>
+          <Text style={styles.gameScore}>{score}pts</Text>
+        </View>
+
+        <View style={styles.gameContent}>
+          <Text style={styles.gameQuestion}>Complete this Ghanaian word:</Text>
+          
+          <View style={styles.wordPuzzleContainer}>
+            {wordLetters.map((letter, index) => (
+              <View key={index} style={styles.puzzleLetter}>
+                {wordPuzzleData.hiddenLetters.includes(index) ? (
+                  <Text style={styles.puzzleBlank}>_</Text>
+                ) : (
+                  <Text style={styles.puzzleLetterText}>{letter}</Text>
+                )}
+              </View>
+            ))}
+          </View>
+
+          <Text style={styles.puzzleHint}>
+            Hint: This is a {culturalWords.find(cat => 
+              cat.words.includes(wordPuzzleData.currentWord)
+            )?.category.toLowerCase()} word
+          </Text>
+
+          <View style={styles.alphabetContainer}>
+            {'ABCDEFGHIJKLMNOPQRSTUVWXYZ'.split('').map(letter => (
+              <TouchableOpacity
+                key={letter}
+                style={styles.alphabetButton}
+                onPress={() => {
+                  // Check if this letter fills any blanks
+                  const wordLetters = wordPuzzleData.currentWord.toUpperCase().split('');
+                  const isCorrect = wordPuzzleData.hiddenLetters.some(index => 
+                    wordLetters[index] === letter
+                  );
+                  
+                  if (isCorrect) {
+                    setScore(score + 5);
+                    playSuccessAnimation();
+                    // Check if puzzle is complete
+                    const newGuessed = [...wordPuzzleData.guessedLetters];
+                    wordPuzzleData.hiddenLetters.forEach(index => {
+                      if (wordLetters[index] === letter) {
+                        newGuessed[index] = letter;
+                      }
+                    });
+                    
+                    setWordPuzzleData({
+                      ...wordPuzzleData,
+                      guessedLetters: newGuessed,
+                    });
+                    
+                    // Check if complete
+                    if (newGuessed.every((l, i) => 
+                      !wordPuzzleData.hiddenLetters.includes(i) || l !== ''
+                    )) {
+                      showEncouragement(true);
+                      setTimeout(initializeWordPuzzle, 1500);
+                    }
+                  } else {
+                    showEncouragement(false);
+                  }
+                }}>
+                <Text style={styles.alphabetButtonText}>{letter}</Text>
+              </TouchableOpacity>
+            ))}
+          </View>
+        </View>
+      </View>
+    );
+  };
+
+  const renderCurrentGame = () => {
+    switch (currentGame) {
+      case 'letterMatch':
+        return <LetterMatchGame />;
+      case 'wordPuzzle':
+        return <WordPuzzleGame />;
+      case 'soundGuess':
+        return (
+          <View style={styles.gameContainer}>
+            <View style={styles.gameHeader}>
+              <TouchableOpacity onPress={() => setCurrentGame('menu')}>
+                <Icon name="arrow-back" size={24} color="#FFF" />
+              </TouchableOpacity>
+              <Text style={styles.gameHeaderTitle}>Sound Detective</Text>
+              <Text style={styles.gameScore}>{score}pts</Text>
+            </View>
+            <View style={styles.comingSoonContainer}>
+              <Icon name="construction" size={60} color="#FF6B35" />
+              <Text style={styles.comingSoonText}>Coming Soon!</Text>
+              <Text style={styles.comingSoonSubtext}>More exciting games are on the way!</Text>
+            </View>
+          </View>
+        );
+      case 'speedMatch':
+        return (
+          <View style={styles.gameContainer}>
+            <View style={styles.gameHeader}>
+              <TouchableOpacity onPress={() => setCurrentGame('menu')}>
+                <Icon name="arrow-back" size={24} color="#FFF" />
+              </TouchableOpacity>
+              <Text style={styles.gameHeaderTitle}>Speed Match</Text>
+              <Text style={styles.gameScore}>{score}pts</Text>
+            </View>
+            <View style={styles.comingSoonContainer}>
+              <Icon name="construction" size={60} color="#FF6B35" />
+              <Text style={styles.comingSoonText}>Coming Soon!</Text>
+              <Text style={styles.comingSoonSubtext}>More exciting games are on the way!</Text>
+            </View>
+          </View>
+        );
+      default:
+        return <GameMenu />;
+    }
+  };
+
+  return (
+    <ScrollView style={styles.container}>
+      {renderCurrentGame()}
+    </ScrollView>
+  );
+};
+
+const styles = StyleSheet.create({
+  container: {
+    flex: 1,
+    backgroundColor: '#F8F9FA',
+  },
+  gameMenuContainer: {
+    padding: 20,
+  },
+  gameMenuTitle: {
+    fontSize: 24,
+    fontWeight: 'bold',
+    color: '#333',
+    textAlign: 'center',
+    marginBottom: 10,
+  },
+  currentScore: {
+    fontSize: 16,
+    color: '#FF6B35',
+    textAlign: 'center',
+    marginBottom: 20,
+    fontWeight: '600',
+  },
+  gamesGrid: {
+    gap: 15,
+  },
+  gameCard: {
+    backgroundColor: '#FFF',
+    borderRadius: 15,
+    padding: 15,
+    flexDirection: 'row',
+    alignItems: 'center',
+    borderLeftWidth: 5,
+    elevation: 3,
+    shadowColor: '#000',
+    shadowOffset: {width: 0, height: 2},
+    shadowOpacity: 0.1,
+    shadowRadius: 4,
+  },
+  gameIcon: {
+    width: 50,
+    height: 50,
+    borderRadius: 25,
+    justifyContent: 'center',
+    alignItems: 'center',
+    marginRight: 15,
+  },
+  gameInfo: {
+    flex: 1,
+  },
+  gameTitle: {
+    fontSize: 16,
+    fontWeight: 'bold',
+    color: '#333',
+    marginBottom: 3,
+  },
+  gameDescription: {
+    fontSize: 14,
+    color: '#666',
+  },
+  gameContainer: {
+    flex: 1,
+  },
+  gameHeader: {
+    backgroundColor: '#96CEB4',
+    flexDirection: 'row',
+    alignItems: 'center',
+    justifyContent: 'space-between',
+    padding: 20,
+    paddingTop: 30,
+  },
+  gameHeaderTitle: {
+    fontSize: 18,
+    fontWeight: 'bold',
+    color: '#FFF',
+    flex: 1,
+    textAlign: 'center',
+  },
+  gameScore: {
+    fontSize: 16,
+    fontWeight: 'bold',
+    color: '#FFF',
+  },
+  gameContent: {
+    padding: 20,
+    alignItems: 'center',
+  },
+  gameQuestion: {
+    fontSize: 18,
+    fontWeight: 'bold',
+    color: '#333',
+    textAlign: 'center',
+    marginBottom: 20,
+  },
+  letterCard: {
+    width: 120,
+    height: 120,
+    borderRadius: 15,
+    justifyContent: 'center',
+    alignItems: 'center',
+    marginBottom: 30,
+    elevation: 5,
+  },
+  letterCardText: {
+    fontSize: 60,
+    fontWeight: 'bold',
+    color: '#FFF',
+  },
+  optionsContainer: {
+    width: '100%',
+  },
+  optionButton: {
+    backgroundColor: '#FFF',
+    borderRadius: 10,
+    padding: 15,
+    marginBottom: 10,
+    alignItems: 'center',
+    borderWidth: 2,
+    borderColor: '#E9ECEF',
+  },
+  optionText: {
+    fontSize: 18,
+    fontWeight: '600',
+    color: '#333',
+  },
+  wordPuzzleContainer: {
+    flexDirection: 'row',
+    justifyContent: 'center',
+    flexWrap: 'wrap',
+    marginBottom: 20,
+  },
+  puzzleLetter: {
+    width: 40,
+    height: 40,
+    borderRadius: 8,
+    backgroundColor: '#FFF',
+    justifyContent: 'center',
+    alignItems: 'center',
+    margin: 2,
+    borderWidth: 2,
+    borderColor: '#E9ECEF',
+  },
+  puzzleLetterText: {
+    fontSize: 20,
+    fontWeight: 'bold',
+    color: '#333',
+  },
+  puzzleBlank: {
+    fontSize: 20,
+    fontWeight: 'bold',
+    color: '#CCC',
+  },
+  puzzleHint: {
+    fontSize: 14,
+    color: '#666',
+    textAlign: 'center',
+    marginBottom: 20,
+    fontStyle: 'italic',
+  },
+  alphabetContainer: {
+    flexDirection: 'row',
+    flexWrap: 'wrap',
+    justifyContent: 'center',
+  },
+  alphabetButton: {
+    width: 35,
+    height: 35,
+    backgroundColor: '#E9ECEF',
+    borderRadius: 8,
+    justifyContent: 'center',
+    alignItems: 'center',
+    margin: 2,
+  },
+  alphabetButtonText: {
+    fontSize: 14,
+    fontWeight: 'bold',
+    color: '#333',
+  },
+  comingSoonContainer: {
+    flex: 1,
+    justifyContent: 'center',
+    alignItems: 'center',
+    padding: 40,
+  },
+  comingSoonText: {
+    fontSize: 24,
+    fontWeight: 'bold',
+    color: '#333',
+    marginTop: 20,
+    marginBottom: 10,
+  },
+  comingSoonSubtext: {
+    fontSize: 16,
+    color: '#666',
+    textAlign: 'center',
+  },
+});
+
+export default GamesScreen;  

diff --git a/src/screens/HomeScreen.js b/src/screens/HomeScreen.js
--- a/src/screens/HomeScreen.js
+++ b/src/screens/HomeScreen.js
@@ -0,0 +1,227 @@
+import React, {useEffect, useState} from 'react';
+import {
+  View,
+  Text,
+  StyleSheet,
+  ScrollView,
+  TouchableOpacity,
+  Animated,
+} from 'react-native';
+import LinearGradient from 'react-native-linear-gradient';
+import Icon from 'react-native-vector-icons/MaterialIcons';
+import {encouragementMessages} from '../data/ghanaianContent';
+
+const HomeScreen = ({navigation}) => {
+  const [currentGreeting, setCurrentGreeting] = useState(0);
+  const fadeAnim = new Animated.Value(1);
+
+  const greetings = [
+    'Akwaaba! Welcome to Letter Sounds!',
+    'Wo yɛ adeɛ! Let\'s learn together!',
+    'Ready to explore letters and sounds?',
+  ];
+
+  useEffect(() => {
+    const interval = setInterval(() => {
+      Animated.sequence([
+        Animated.timing(fadeAnim, {
+          toValue: 0,
+          duration: 500,
+          useNativeDriver: true,
+        }),
+        Animated.timing(fadeAnim, {
+          toValue: 1,
+          duration: 500,
+          useNativeDriver: true,
+        }),
+      ]).start();
+
+      setCurrentGreeting((prev) => (prev + 1) % greetings.length);
+    }, 3000);
+
+    return () => clearInterval(interval);
+  }, []);
+
+  const features = [
+    {
+      title: 'Letter Sounds',
+      description: 'Learn how each letter sounds with Ghanaian examples',
+      icon: 'record-voice-over',
+      color: '#FF6B35',
+      screen: 'Letters',
+    },
+    {
+      title: 'Build Words',
+      description: 'Create words using letters and hear their sounds',
+      icon: 'text-fields',
+      color: '#4ECDC4',
+      screen: 'Words',
+    },
+    {
+      title: 'Make Sentences',
+      description: 'Put words together to form meaningful sentences',
+      icon: 'format-list-bulleted',
+      color: '#45B7D1',
+      screen: 'Sentences',
+    },
+    {
+      title: 'Fun Games',
+      description: 'Play exciting games while learning',
+      icon: 'games',
+      color: '#96CEB4',
+      screen: 'Games',
+    },
+  ];
+
+  return (
+    <ScrollView style={styles.container}>
+      <LinearGradient
+        colors={['#FF6B35', '#F7931E', '#FFD93D']}
+        style={styles.header}>
+        <Animated.Text style={[styles.greeting, {opacity: fadeAnim}]}>
+          {greetings[currentGreeting]}
+        </Animated.Text>
+        <Text style={styles.subtitle}>
+          Learning letters has never been this fun! 🇬🇭
+        </Text>
+      </LinearGradient>
+
+      <View style={styles.content}>
+        <Text style={styles.sectionTitle}>What would you like to do today?</Text>
+        
+        {features.map((feature, index) => (
+          <TouchableOpacity
+            key={index}
+            style={[styles.featureCard, {borderLeftColor: feature.color}]}
+            onPress={() => navigation.navigate(feature.screen)}>
+            <View style={styles.featureIcon}>
+              <Icon name={feature.icon} size={40} color={feature.color} />
+            </View>
+            <View style={styles.featureContent}>
+              <Text style={styles.featureTitle}>{feature.title}</Text>
+              <Text style={styles.featureDescription}>{feature.description}</Text>
+            </View>
+            <Icon name="arrow-forward-ios" size={20} color="#666" />
+          </TouchableOpacity>
+        ))}
+
+        <View style={styles.encouragementBox}>
+          <Text style={styles.encouragementText}>
+            {encouragementMessages[Math.floor(Math.random() * encouragementMessages.length)]}
+          </Text>
+        </View>
+
+        <View style={styles.aboutSection}>
+          <Text style={styles.aboutTitle}>About This App</Text>
+          <Text style={styles.aboutText}>
+            This app helps Ghanaian children learn letter sounds through fun, 
+            interactive activities using familiar words and cultural references. 
+            From Adinkra symbols to Jollof rice, learning becomes an exciting journey!
+          </Text>
+        </View>
+      </View>
+    </ScrollView>
+  );
+};
+
+const styles = StyleSheet.create({
+  container: {
+    flex: 1,
+    backgroundColor: '#F8F9FA',
+  },
+  header: {
+    padding: 30,
+    paddingTop: 50,
+    borderBottomLeftRadius: 30,
+    borderBottomRightRadius: 30,
+  },
+  greeting: {
+    fontSize: 24,
+    fontWeight: 'bold',
+    color: '#FFF',
+    textAlign: 'center',
+    marginBottom: 10,
+  },
+  subtitle: {
+    fontSize: 16,
+    color: '#FFF',
+    textAlign: 'center',
+    opacity: 0.9,
+  },
+  content: {
+    padding: 20,
+  },
+  sectionTitle: {
+    fontSize: 20,
+    fontWeight: 'bold',
+    color: '#333',
+    marginBottom: 20,
+    textAlign: 'center',
+  },
+  featureCard: {
+    backgroundColor: '#FFF',
+    borderRadius: 15,
+    padding: 20,
+    marginBottom: 15,
+    flexDirection: 'row',
+    alignItems: 'center',
+    borderLeftWidth: 5,
+    elevation: 3,
+    shadowColor: '#000',
+    shadowOffset: {width: 0, height: 2},
+    shadowOpacity: 0.1,
+    shadowRadius: 4,
+  },
+  featureIcon: {
+    marginRight: 15,
+  },
+  featureContent: {
+    flex: 1,
+  },
+  featureTitle: {
+    fontSize: 18,
+    fontWeight: 'bold',
+    color: '#333',
+    marginBottom: 5,
+  },
+  featureDescription: {
+    fontSize: 14,
+    color: '#666',
+    lineHeight: 20,
+  },
+  encouragementBox: {
+    backgroundColor: '#FFE4E1',
+    borderRadius: 15,
+    padding: 20,
+    marginVertical: 20,
+    borderLeftWidth: 5,
+    borderLeftColor: '#FF6B35',
+  },
+  encouragementText: {
+    fontSize: 16,
+    color: '#D63031',
+    fontWeight: '600',
+    textAlign: 'center',
+  },
+  aboutSection: {
+    backgroundColor: '#E8F4FD',
+    borderRadius: 15,
+    padding: 20,
+    marginTop: 10,
+  },
+  aboutTitle: {
+    fontSize: 18,
+    fontWeight: 'bold',
+    color: '#2D3436',
+    marginBottom: 10,
+    textAlign: 'center',
+  },
+  aboutText: {
+    fontSize: 14,
+    color: '#636E72',
+    lineHeight: 22,
+    textAlign: 'center',
+  },
+});
+
+export default HomeScreen;

diff --git a/src/screens/LetterSoundsScreen.js b/src/screens/LetterSoundsScreen.js
--- a/src/screens/LetterSoundsScreen.js
+++ b/src/screens/LetterSoundsScreen.js
@@ -0,0 +1,370 @@
+import React, {useState, useRef} from 'react';
+import {
+  View,
+  Text,
+  StyleSheet,
+  ScrollView,
+  TouchableOpacity,
+  Animated,
+  Alert,
+} from 'react-native';
+import Icon from 'react-native-vector-icons/MaterialIcons';
+import {letters} from '../data/ghanaianContent';
+
+const LetterSoundsScreen = () => {
+  const [selectedLetter, setSelectedLetter] = useState(null);
+  const [currentExample, setCurrentExample] = useState(0);
+  const scaleAnim = useRef(new Animated.Value(1)).current;
+  const bounceAnim = useRef(new Animated.Value(0)).current;
+
+  const playLetterSound = (letter) => {
+    // Animate the letter when played
+    Animated.sequence([
+      Animated.timing(scaleAnim, {
+        toValue: 1.2,
+        duration: 200,
+        useNativeDriver: true,
+      }),
+      Animated.timing(scaleAnim, {
+        toValue: 1,
+        duration: 200,
+        useNativeDriver: true,
+      }),
+    ]).start();
+
+    // In a real app, you would use react-native-sound to play audio
+    Alert.alert(
+      'Letter Sound',
+      `The letter ${letter.letter} makes the sound ${letter.sound}\n\nExample: ${letter.examples[currentExample].word} - ${letter.examples[currentExample].meaning}`,
+      [{text: 'Great!', style: 'default'}]
+    );
+  };
+
+  const selectLetter = (letter) => {
+    setSelectedLetter(letter);
+    setCurrentExample(0);
+    
+    // Bounce animation for selection
+    Animated.spring(bounceAnim, {
+      toValue: 1,
+      friction: 3,
+      tension: 40,
+      useNativeDriver: true,
+    }).start();
+  };
+
+  const nextExample = () => {
+    if (selectedLetter && currentExample < selectedLetter.examples.length - 1) {
+      setCurrentExample(currentExample + 1);
+    } else if (selectedLetter) {
+      setCurrentExample(0);
+    }
+  };
+
+  const LetterCard = ({letter}) => (
+    <TouchableOpacity
+      style={[styles.letterCard, {backgroundColor: letter.color}]}
+      onPress={() => selectLetter(letter)}>
+      <Animated.Text
+        style={[
+          styles.letterText,
+          selectedLetter?.letter === letter.letter && {
+            transform: [{scale: scaleAnim}],
+          },
+        ]}>
+        {letter.letter}
+      </Animated.Text>
+      <Text style={styles.soundText}>{letter.sound}</Text>
+      <TouchableOpacity
+        style={styles.playButton}
+        onPress={() => playLetterSound(letter)}>
+        <Icon name="play-arrow" size={20} color="#FFF" />
+      </TouchableOpacity>
+    </TouchableOpacity>
+  );
+
+  return (
+    <View style={styles.container}>
+      <View style={styles.header}>
+        <Text style={styles.title}>Learn Letter Sounds</Text>
+        <Text style={styles.subtitle}>Tap any letter to hear its sound!</Text>
+      </View>
+
+      <ScrollView style={styles.lettersContainer}>
+        <View style={styles.lettersGrid}>
+          {letters.map((letter, index) => (
+            <LetterCard key={index} letter={letter} />
+          ))}
+        </View>
+      </ScrollView>
+
+      {selectedLetter && (
+        <Animated.View
+          style={[
+            styles.detailsPanel,
+            {
+              transform: [
+                {
+                  translateY: bounceAnim.interpolate({
+                    inputRange: [0, 1],
+                    outputRange: [300, 0],
+                  }),
+                },
+              ],
+            },
+          ]}>
+          <View style={styles.detailsHeader}>
+            <Text style={styles.detailsTitle}>
+              Letter {selectedLetter.letter}
+            </Text>
+            <TouchableOpacity
+              style={styles.closeButton}
+              onPress={() => {
+                setSelectedLetter(null);
+                bounceAnim.setValue(0);
+              }}>
+              <Icon name="close" size={24} color="#666" />
+            </TouchableOpacity>
+          </View>
+
+          <View style={styles.exampleCard}>
+            <View style={styles.exampleHeader}>
+              <Text style={styles.exampleWord}>
+                {selectedLetter.examples[currentExample].word}
+              </Text>
+              <TouchableOpacity
+                style={[styles.soundButton, {backgroundColor: selectedLetter.color}]}
+                onPress={() => playLetterSound(selectedLetter)}>
+                <Icon name="volume-up" size={24} color="#FFF" />
+              </TouchableOpacity>
+            </View>
+            
+            <Text style={styles.exampleMeaning}>
+              {selectedLetter.examples[currentExample].meaning}
+            </Text>
+
+            <View style={styles.navigationButtons}>
+              <TouchableOpacity style={styles.navButton} onPress={nextExample}>
+                <Icon name="skip-next" size={20} color="#666" />
+                <Text style={styles.navButtonText}>Next Example</Text>
+              </TouchableOpacity>
+            </View>
+
+            <View style={styles.exampleIndicators}>
+              {selectedLetter.examples.map((_, index) => (
+                <View
+                  key={index}
+                  style={[
+                    styles.indicator,
+                    index === currentExample && styles.activeIndicator,
+                    {backgroundColor: index === currentExample ? selectedLetter.color : '#DDD'},
+                  ]}
+                />
+              ))}
+            </View>
+          </View>
+
+          <View style={styles.practiceSection}>
+            <Text style={styles.practiceTitle}>Practice Activity</Text>
+            <Text style={styles.practiceText}>
+              Can you think of another Ghanaian word that starts with "{selectedLetter.letter}"?
+            </Text>
+            <TouchableOpacity
+              style={[styles.practiceButton, {backgroundColor: selectedLetter.color}]}>
+              <Text style={styles.practiceButtonText}>I found one!</Text>
+            </TouchableOpacity>
+          </View>
+        </Animated.View>
+      )}
+    </View>
+  );
+};
+
+const styles = StyleSheet.create({
+  container: {
+    flex: 1,
+    backgroundColor: '#F8F9FA',
+  },
+  header: {
+    backgroundColor: '#FF6B35',
+    padding: 20,
+    paddingTop: 30,
+  },
+  title: {
+    fontSize: 24,
+    fontWeight: 'bold',
+    color: '#FFF',
+    textAlign: 'center',
+  },
+  subtitle: {
+    fontSize: 16,
+    color: '#FFF',
+    textAlign: 'center',
+    marginTop: 5,
+    opacity: 0.9,
+  },
+  lettersContainer: {
+    flex: 1,
+    padding: 15,
+  },
+  lettersGrid: {
+    flexDirection: 'row',
+    flexWrap: 'wrap',
+    justifyContent: 'space-between',
+  },
+  letterCard: {
+    width: '48%',
+    aspectRatio: 1,
+    borderRadius: 15,
+    padding: 15,
+    marginBottom: 15,
+    alignItems: 'center',
+    justifyContent: 'center',
+    position: 'relative',
+    elevation: 3,
+    shadowColor: '#000',
+    shadowOffset: {width: 0, height: 2},
+    shadowOpacity: 0.1,
+    shadowRadius: 4,
+  },
+  letterText: {
+    fontSize: 48,
+    fontWeight: 'bold',
+    color: '#FFF',
+    textAlign: 'center',
+  },
+  soundText: {
+    fontSize: 18,
+    color: '#FFF',
+    marginTop: 5,
+    opacity: 0.9,
+  },
+  playButton: {
+    position: 'absolute',
+    top: 10,
+    right: 10,
+    backgroundColor: 'rgba(0,0,0,0.2)',
+    borderRadius: 15,
+    padding: 5,
+  },
+  detailsPanel: {
+    position: 'absolute',
+    bottom: 0,
+    left: 0,
+    right: 0,
+    backgroundColor: '#FFF',
+    borderTopLeftRadius: 25,
+    borderTopRightRadius: 25,
+    padding: 20,
+    maxHeight: '60%',
+    elevation: 10,
+    shadowColor: '#000',
+    shadowOffset: {width: 0, height: -2},
+    shadowOpacity: 0.2,
+    shadowRadius: 8,
+  },
+  detailsHeader: {
+    flexDirection: 'row',
+    justifyContent: 'space-between',
+    alignItems: 'center',
+    marginBottom: 20,
+  },
+  detailsTitle: {
+    fontSize: 20,
+    fontWeight: 'bold',
+    color: '#333',
+  },
+  closeButton: {
+    padding: 5,
+  },
+  exampleCard: {
+    backgroundColor: '#F8F9FA',
+    borderRadius: 15,
+    padding: 15,
+    marginBottom: 15,
+  },
+  exampleHeader: {
+    flexDirection: 'row',
+    justifyContent: 'space-between',
+    alignItems: 'center',
+    marginBottom: 10,
+  },
+  exampleWord: {
+    fontSize: 24,
+    fontWeight: 'bold',
+    color: '#333',
+  },
+  soundButton: {
+    borderRadius: 20,
+    padding: 8,
+  },
+  exampleMeaning: {
+    fontSize: 16,
+    color: '#666',
+    marginBottom: 15,
+    lineHeight: 22,
+  },
+  navigationButtons: {
+    flexDirection: 'row',
+    justifyContent: 'center',
+    marginBottom: 15,
+  },
+  navButton: {
+    flexDirection: 'row',
+    alignItems: 'center',
+    backgroundColor: '#E9ECEF',
+    borderRadius: 20,
+    paddingHorizontal: 15,
+    paddingVertical: 8,
+  },
+  navButtonText: {
+    marginLeft: 5,
+    color: '#666',
+    fontWeight: '600',
+  },
+  exampleIndicators: {
+    flexDirection: 'row',
+    justifyContent: 'center',
+  },
+  indicator: {
+    width: 8,
+    height: 8,
+    borderRadius: 4,
+    marginHorizontal: 3,
+  },
+  activeIndicator: {
+    width: 20,
+  },
+  practiceSection: {
+    backgroundColor: '#E8F4FD',
+    borderRadius: 15,
+    padding: 15,
+  },
+  practiceTitle: {
+    fontSize: 16,
+    fontWeight: 'bold',
+    color: '#333',
+    marginBottom: 8,
+    textAlign: 'center',
+  },
+  practiceText: {
+    fontSize: 14,
+    color: '#666',
+    textAlign: 'center',
+    marginBottom: 15,
+    lineHeight: 20,
+  },
+  practiceButton: {
+    borderRadius: 20,
+    paddingVertical: 10,
+    paddingHorizontal: 20,
+    alignSelf: 'center',
+  },
+  practiceButtonText: {
+    color: '#FFF',
+    fontWeight: 'bold',
+    fontSize: 14,
+  },
+});
+
+export default LetterSoundsScreen; 

diff --git a/src/screens/ProgressScreen.js b/src/screens/ProgressScreen.js
--- a/src/screens/ProgressScreen.js
+++ b/src/screens/ProgressScreen.js
@@ -0,0 +1,706 @@
+import React, {useState, useRef} from 'react';
+import {
+  View,
+  Text,
+  StyleSheet,
+  ScrollView,
+  TouchableOpacity,
+  Animated,
+  Dimensions,
+} from 'react-native';
+import Icon from 'react-native-vector-icons/MaterialIcons';
+import {letters, culturalWords, encouragementMessages} from '../data/ghanaianContent';
+
+const {width} = Dimensions.get('window');
+
+const ProgressScreen = () => {
+  const [selectedTab, setSelectedTab] = useState('overview');
+  const animatedValue = useRef(new Animated.Value(0)).current;
+
+  // Simulated progress data (in a real app, this would come from AsyncStorage or a database)
+  const progressData = {
+    lettersLearned: 7, // out of 26
+    wordsCompleted: 12, // out of available words
+    sentencesBuilt: 5,
+    gamesPlayed: 3,
+    totalScore: 250,
+    streakDays: 3,
+    timeSpent: 45, // minutes
+    achievements: [
+      {id: 1, title: 'First Letter!', description: 'Learned your first letter sound', icon: 'grade', earned: true},
+      {id: 2, title: 'Word Builder', description: 'Built 10 words successfully', icon: 'build', earned: true},
+      {id: 3, title: 'Sentence Master', description: 'Created 5 complete sentences', icon: 'format-list-bulleted', earned: true},
+      {id: 4, title: 'Game Champion', description: 'Played all available games', icon: 'sports-esports', earned: false},
+      {id: 5, title: 'Letter Expert', description: 'Mastered all 26 letters', icon: 'school', earned: false},
+      {id: 6, title: 'Ghana Pride', description: 'Learned 20 Ghanaian cultural words', icon: 'flag', earned: false},
+    ],
+    weeklyProgress: [
+      {day: 'Mon', letters: 2, words: 3, sentences: 1},
+      {day: 'Tue', letters: 1, words: 2, sentences: 0},
+      {day: 'Wed', letters: 3, words: 4, sentences: 2},
+      {day: 'Thu', letters: 0, words: 1, sentences: 1},
+      {day: 'Fri', letters: 1, words: 2, sentences: 1},
+      {day: 'Sat', letters: 0, words: 0, sentences: 0},
+      {day: 'Sun', letters: 0, words: 0, sentences: 0},
+    ],
+  };
+
+  const calculateProgress = () => {
+    const letterProgress = (progressData.lettersLearned / 26) * 100;
+    const wordProgress = (progressData.wordsCompleted / 25) * 100; // assuming 25 total words
+    const achievementProgress = (progressData.achievements.filter(a => a.earned).length / progressData.achievements.length) * 100;
+    
+    return {
+      letter: Math.round(letterProgress),
+      word: Math.round(wordProgress),
+      achievement: Math.round(achievementProgress),
+    };
+  };
+
+  const progress = calculateProgress();
+
+  const ProgressBar = ({label, percentage, color}) => (
+    <View style={styles.progressBarContainer}>
+      <View style={styles.progressBarHeader}>
+        <Text style={styles.progressBarLabel}>{label}</Text>
+        <Text style={styles.progressBarPercentage}>{percentage}%</Text>
+      </View>
+      <View style={styles.progressBarTrack}>
+        <Animated.View
+          style={[
+            styles.progressBarFill,
+            {
+              backgroundColor: color,
+              width: `${percentage}%`,
+            },
+          ]}
+        />
+      </View>
+    </View>
+  );
+
+  const StatCard = ({icon, value, label, color}) => (
+    <View style={[styles.statCard, {borderTopColor: color}]}>
+      <Icon name={icon} size={30} color={color} />
+      <Text style={styles.statValue}>{value}</Text>
+      <Text style={styles.statLabel}>{label}</Text>
+    </View>
+  );
+
+  const AchievementBadge = ({achievement}) => (
+    <View style={[
+      styles.achievementBadge,
+      !achievement.earned && styles.achievementBadgeDisabled,
+    ]}>
+      <View style={[
+        styles.achievementIcon,
+        {backgroundColor: achievement.earned ? '#4CAF50' : '#CCC'},
+      ]}>
+        <Icon 
+          name={achievement.icon} 
+          size={24} 
+          color={achievement.earned ? '#FFF' : '#666'} 
+        />
+      </View>
+      <View style={styles.achievementContent}>
+        <Text style={[
+          styles.achievementTitle,
+          !achievement.earned && styles.achievementTitleDisabled,
+        ]}>
+          {achievement.title}
+        </Text>
+        <Text style={[
+          styles.achievementDescription,
+          !achievement.earned && styles.achievementDescriptionDisabled,
+        ]}>
+          {achievement.description}
+        </Text>
+      </View>
+      {achievement.earned && (
+        <Icon name="check-circle" size={20} color="#4CAF50" />
+      )}
+    </View>
+  );
+
+  const WeeklyChart = () => (
+    <View style={styles.chartContainer}>
+      <Text style={styles.chartTitle}>This Week's Learning</Text>
+      <View style={styles.chartBars}>
+        {progressData.weeklyProgress.map((day, index) => {
+          const total = day.letters + day.words + day.sentences;
+          const maxHeight = 80;
+          const barHeight = total > 0 ? Math.max(10, (total / 10) * maxHeight) : 5;
+          
+          return (
+            <View key={index} style={styles.chartDay}>
+              <View style={styles.chartBarContainer}>
+                <View
+                  style={[
+                    styles.chartBar,
+                    {
+                      height: barHeight,
+                      backgroundColor: total > 0 ? '#4CAF50' : '#E9ECEF',
+                    },
+                  ]}
+                />
+              </View>
+              <Text style={styles.chartDayLabel}>{day.day}</Text>
+              <Text style={styles.chartDayValue}>{total}</Text>
+            </View>
+          );
+        })}
+      </View>
+      <Text style={styles.chartLegend}>Activities completed each day</Text>
+    </View>
+  );
+
+  const OverviewTab = () => (
+    <ScrollView style={styles.tabContent}>
+      {/* Welcome Message */}
+      <View style={styles.welcomeCard}>
+        <Text style={styles.welcomeTitle}>Akwaaba back! 🇬🇭</Text>
+        <Text style={styles.welcomeText}>
+          {encouragementMessages[Math.floor(Math.random() * encouragementMessages.length)]}
+        </Text>
+        <Text style={styles.streakText}>🔥 {progressData.streakDays} day streak!</Text>
+      </View>
+
+      {/* Quick Stats */}
+      <View style={styles.statsContainer}>
+        <StatCard
+          icon="record-voice-over"
+          value={progressData.lettersLearned}
+          label="Letters Learned"
+          color="#FF6B35"
+        />
+        <StatCard
+          icon="text-fields"
+          value={progressData.wordsCompleted}
+          label="Words Built"
+          color="#4ECDC4"
+        />
+        <StatCard
+          icon="format-list-bulleted"
+          value={progressData.sentencesBuilt}
+          label="Sentences Made"
+          color="#45B7D1"
+        />
+        <StatCard
+          icon="sports-esports"
+          value={progressData.totalScore}
+          label="Total Score"
+          color="#96CEB4"
+        />
+      </View>
+
+      {/* Progress Bars */}
+      <View style={styles.progressSection}>
+        <Text style={styles.sectionTitle}>Your Learning Progress</Text>
+        <ProgressBar
+          label="Letter Sounds"
+          percentage={progress.letter}
+          color="#FF6B35"
+        />
+        <ProgressBar
+          label="Word Building"
+          percentage={progress.word}
+          color="#4ECDC4"
+        />
+        <ProgressBar
+          label="Achievements"
+          percentage={progress.achievement}
+          color="#96CEB4"
+        />
+      </View>
+
+      {/* Weekly Chart */}
+      <WeeklyChart />
+    </ScrollView>
+  );
+
+  const AchievementsTab = () => (
+    <ScrollView style={styles.tabContent}>
+      <View style={styles.achievementsHeader}>
+        <Text style={styles.sectionTitle}>Your Achievements</Text>
+        <Text style={styles.achievementsSummary}>
+          {progressData.achievements.filter(a => a.earned).length} of {progressData.achievements.length} earned
+        </Text>
+      </View>
+
+      <View style={styles.achievementsList}>
+        {progressData.achievements.map((achievement) => (
+          <AchievementBadge key={achievement.id} achievement={achievement} />
+        ))}
+      </View>
+
+      <View style={styles.motivationCard}>
+        <Icon name="emoji-events" size={40} color="#FFD93D" />
+        <Text style={styles.motivationTitle}>Keep Going!</Text>
+        <Text style={styles.motivationText}>
+          Every letter you learn and word you build makes you stronger! 
+          Complete more activities to earn new achievements.
+        </Text>
+      </View>
+    </ScrollView>
+  );
+
+  const DetailsTab = () => (
+    <ScrollView style={styles.tabContent}>
+      <View style={styles.detailsContainer}>
+        <Text style={styles.sectionTitle}>Learning Details</Text>
+        
+        <View style={styles.detailCard}>
+          <Text style={styles.detailCardTitle}>Letters Mastered ({progressData.lettersLearned}/26)</Text>
+          <View style={styles.lettersGrid}>
+            {letters.slice(0, 10).map((letter, index) => (
+              <View
+                key={index}
+                style={[
+                  styles.letterBadge,
+                  {
+                    backgroundColor: index < progressData.lettersLearned ? letter.color : '#E9ECEF',
+                  },
+                ]}>
+                <Text style={[
+                  styles.letterBadgeText,
+                  {color: index < progressData.lettersLearned ? '#FFF' : '#999'},
+                ]}>
+                  {letter.letter}
+                </Text>
+              </View>
+            ))}
+          </View>
+        </View>
+
+        <View style={styles.detailCard}>
+          <Text style={styles.detailCardTitle}>Cultural Words Learned</Text>
+          {culturalWords.map((category, index) => {
+            const learned = Math.min(category.words.length, Math.floor(progressData.wordsCompleted / culturalWords.length) + (index < progressData.wordsCompleted % culturalWords.length ? 1 : 0));
+            return (
+              <View key={index} style={styles.categoryProgress}>
+                <Text style={styles.categoryName}>{category.category}</Text>
+                <View style={styles.categoryBar}>
+                  <View
+                    style={[
+                      styles.categoryBarFill,
+                      {width: `${(learned / category.words.length) * 100}%`},
+                    ]}
+                  />
+                </View>
+                <Text style={styles.categoryStats}>{learned}/{category.words.length}</Text>
+              </View>
+            );
+          })}
+        </View>
+
+        <View style={styles.detailCard}>
+          <Text style={styles.detailCardTitle}>Time & Activity</Text>
+          <View style={styles.timeStats}>
+            <View style={styles.timeStat}>
+              <Icon name="access-time" size={24} color="#FF6B35" />
+              <Text style={styles.timeStatLabel}>Time Spent</Text>
+              <Text style={styles.timeStatValue}>{progressData.timeSpent} min</Text>
+            </View>
+            <View style={styles.timeStat}>
+              <Icon name="event" size={24} color="#4ECDC4" />
+              <Text style={styles.timeStatLabel}>Days Active</Text>
+              <Text style={styles.timeStatValue}>{progressData.streakDays} days</Text>
+            </View>
+          </View>
+        </View>
+      </View>
+    </ScrollView>
+  );
+
+  const TabButton = ({id, title, icon, isActive, onPress}) => (
+    <TouchableOpacity
+      style={[styles.tabButton, isActive && styles.activeTabButton]}
+      onPress={onPress}>
+      <Icon name={icon} size={20} color={isActive ? '#FFF' : '#666'} />
+      <Text style={[styles.tabButtonText, isActive && styles.activeTabButtonText]}>
+        {title}
+      </Text>
+    </TouchableOpacity>
+  );
+
+  return (
+    <View style={styles.container}>
+      <View style={styles.header}>
+        <Text style={styles.title}>My Progress</Text>
+        <Text style={styles.subtitle}>Track your amazing learning journey!</Text>
+      </View>
+
+      <View style={styles.tabsContainer}>
+        <TabButton
+          id="overview"
+          title="Overview"
+          icon="dashboard"
+          isActive={selectedTab === 'overview'}
+          onPress={() => setSelectedTab('overview')}
+        />
+        <TabButton
+          id="achievements"
+          title="Achievements"
+          icon="emoji-events"
+          isActive={selectedTab === 'achievements'}
+          onPress={() => setSelectedTab('achievements')}
+        />
+        <TabButton
+          id="details"
+          title="Details"
+          icon="analytics"
+          isActive={selectedTab === 'details'}
+          onPress={() => setSelectedTab('details')}
+        />
+      </View>
+
+      {selectedTab === 'overview' && <OverviewTab />}
+      {selectedTab === 'achievements' && <AchievementsTab />}
+      {selectedTab === 'details' && <DetailsTab />}
+    </View>
+  );
+};
+
+const styles = StyleSheet.create({
+  container: {
+    flex: 1,
+    backgroundColor: '#F8F9FA',
+  },
+  header: {
+    backgroundColor: '#96CEB4',
+    padding: 20,
+    paddingTop: 30,
+  },
+  title: {
+    fontSize: 24,
+    fontWeight: 'bold',
+    color: '#FFF',
+    textAlign: 'center',
+  },
+  subtitle: {
+    fontSize: 16,
+    color: '#FFF',
+    textAlign: 'center',
+    marginTop: 5,
+    opacity: 0.9,
+  },
+  tabsContainer: {
+    flexDirection: 'row',
+    backgroundColor: '#FFF',
+    elevation: 2,
+  },
+  tabButton: {
+    flex: 1,
+    flexDirection: 'row',
+    alignItems: 'center',
+    justifyContent: 'center',
+    paddingVertical: 15,
+    backgroundColor: '#FFF',
+  },
+  activeTabButton: {
+    backgroundColor: '#96CEB4',
+  },
+  tabButtonText: {
+    marginLeft: 5,
+    fontSize: 14,
+    fontWeight: '600',
+    color: '#666',
+  },
+  activeTabButtonText: {
+    color: '#FFF',
+  },
+  tabContent: {
+    flex: 1,
+  },
+  welcomeCard: {
+    backgroundColor: '#FFF',
+    margin: 15,
+    borderRadius: 15,
+    padding: 20,
+    alignItems: 'center',
+    elevation: 2,
+  },
+  welcomeTitle: {
+    fontSize: 20,
+    fontWeight: 'bold',
+    color: '#333',
+    marginBottom: 8,
+  },
+  welcomeText: {
+    fontSize: 16,
+    color: '#666',
+    textAlign: 'center',
+    marginBottom: 10,
+  },
+  streakText: {
+    fontSize: 18,
+    fontWeight: 'bold',
+    color: '#FF6B35',
+  },
+  statsContainer: {
+    flexDirection: 'row',
+    flexWrap: 'wrap',
+    padding: 15,
+    justifyContent: 'space-between',
+  },
+  statCard: {
+    backgroundColor: '#FFF',
+    borderRadius: 15,
+    padding: 15,
+    alignItems: 'center',
+    width: '48%',
+    marginBottom: 10,
+    borderTopWidth: 4,
+    elevation: 2,
+  },
+  statValue: {
+    fontSize: 24,
+    fontWeight: 'bold',
+    color: '#333',
+    marginVertical: 5,
+  },
+  statLabel: {
+    fontSize: 12,
+    color: '#666',
+    textAlign: 'center',
+  },
+  progressSection: {
+    backgroundColor: '#FFF',
+    margin: 15,
+    borderRadius: 15,
+    padding: 20,
+    elevation: 2,
+  },
+  sectionTitle: {
+    fontSize: 18,
+    fontWeight: 'bold',
+    color: '#333',
+    marginBottom: 15,
+  },
+  progressBarContainer: {
+    marginBottom: 15,
+  },
+  progressBarHeader: {
+    flexDirection: 'row',
+    justifyContent: 'space-between',
+    marginBottom: 5,
+  },
+  progressBarLabel: {
+    fontSize: 14,
+    color: '#333',
+    fontWeight: '600',
+  },
+  progressBarPercentage: {
+    fontSize: 14,
+    color: '#666',
+    fontWeight: 'bold',
+  },
+  progressBarTrack: {
+    height: 8,
+    backgroundColor: '#E9ECEF',
+    borderRadius: 4,
+    overflow: 'hidden',
+  },
+  progressBarFill: {
+    height: '100%',
+    borderRadius: 4,
+  },
+  chartContainer: {
+    backgroundColor: '#FFF',
+    margin: 15,
+    borderRadius: 15,
+    padding: 20,
+    elevation: 2,
+  },
+  chartTitle: {
+    fontSize: 16,
+    fontWeight: 'bold',
+    color: '#333',
+    marginBottom: 15,
+    textAlign: 'center',
+  },
+  chartBars: {
+    flexDirection: 'row',
+    justifyContent: 'space-around',
+    alignItems: 'flex-end',
+    height: 100,
+    marginBottom: 10,
+  },
+  chartDay: {
+    alignItems: 'center',
+    flex: 1,
+  },
+  chartBarContainer: {
+    height: 80,
+    justifyContent: 'flex-end',
+    marginBottom: 5,
+  },
+  chartBar: {
+    width: 20,
+    borderRadius: 2,
+  },
+  chartDayLabel: {
+    fontSize: 12,
+    color: '#666',
+    marginBottom: 2,
+  },
+  chartDayValue: {
+    fontSize: 12,
+    fontWeight: 'bold',
+    color: '#333',
+  },
+  chartLegend: {
+    fontSize: 12,
+    color: '#666',
+    textAlign: 'center',
+    fontStyle: 'italic',
+  },
+  achievementsHeader: {
+    padding: 15,
+    alignItems: 'center',
+  },
+  achievementsSummary: {
+    fontSize: 14,
+    color: '#666',
+    marginTop: 5,
+  },
+  achievementsList: {
+    padding: 15,
+  },
+  achievementBadge: {
+    backgroundColor: '#FFF',
+    borderRadius: 15,
+    padding: 15,
+    marginBottom: 10,
+    flexDirection: 'row',
+    alignItems: 'center',
+    elevation: 2,
+  },
+  achievementBadgeDisabled: {
+    opacity: 0.6,
+  },
+  achievementIcon: {
+    width: 50,
+    height: 50,
+    borderRadius: 25,
+    justifyContent: 'center',
+    alignItems: 'center',
+    marginRight: 15,
+  },
+  achievementContent: {
+    flex: 1,
+  },
+  achievementTitle: {
+    fontSize: 16,
+    fontWeight: 'bold',
+    color: '#333',
+    marginBottom: 3,
+  },
+  achievementTitleDisabled: {
+    color: '#999',
+  },
+  achievementDescription: {
+    fontSize: 14,
+    color: '#666',
+  },
+  achievementDescriptionDisabled: {
+    color: '#BBB',
+  },
+  motivationCard: {
+    backgroundColor: '#FFF8E1',
+    margin: 15,
+    borderRadius: 15,
+    padding: 20,
+    alignItems: 'center',
+  },
+  motivationTitle: {
+    fontSize: 18,
+    fontWeight: 'bold',
+    color: '#333',
+    marginVertical: 10,
+  },
+  motivationText: {
+    fontSize: 14,
+    color: '#666',
+    textAlign: 'center',
+    lineHeight: 20,
+  },
+  detailsContainer: {
+    padding: 15,
+  },
+  detailCard: {
+    backgroundColor: '#FFF',
+    borderRadius: 15,
+    padding: 20,
+    marginBottom: 15,
+    elevation: 2,
+  },
+  detailCardTitle: {
+    fontSize: 16,
+    fontWeight: 'bold',
+    color: '#333',
+    marginBottom: 15,
+  },
+  lettersGrid: {
+    flexDirection: 'row',
+    flexWrap: 'wrap',
+    justifyContent: 'center',
+  },
+  letterBadge: {
+    width: 35,
+    height: 35,
+    borderRadius: 8,
+    justifyContent: 'center',
+    alignItems: 'center',
+    margin: 3,
+  },
+  letterBadgeText: {
+    fontSize: 16,
+    fontWeight: 'bold',
+  },
+  categoryProgress: {
+    marginBottom: 15,
+  },
+  categoryName: {
+    fontSize: 14,
+    fontWeight: '600',
+    color: '#333',
+    marginBottom: 5,
+  },
+  categoryBar: {
+    height: 6,
+    backgroundColor: '#E9ECEF',
+    borderRadius: 3,
+    marginBottom: 3,
+  },
+  categoryBarFill: {
+    height: '100%',
+    backgroundColor: '#4ECDC4',
+    borderRadius: 3,
+  },
+  categoryStats: {
+    fontSize: 12,
+    color: '#666',
+    textAlign: 'right',
+  },
+  timeStats: {
+    flexDirection: 'row',
+    justifyContent: 'space-around',
+  },
+  timeStat: {
+    alignItems: 'center',
+  },
+  timeStatLabel: {
+    fontSize: 12,
+    color: '#666',
+    marginTop: 5,
+  },
+  timeStatValue: {
+    fontSize: 16,
+    fontWeight: 'bold',
+    color: '#333',
+    marginTop: 2,
+  },
+});
+
+export default ProgressScreen; 
diff --git a/src/screens/SentenceBuilderScreen.js b/src/screens/SentenceBuilderScreen.js
--- a/src/screens/SentenceBuilderScreen.js
+++ b/src/screens/SentenceBuilderScreen.js
@@ -0,0 +1,583 @@
+import React, {useState, useRef} from 'react';
+import {
+  View,
+  Text,
+  StyleSheet,
+  ScrollView,
+  TouchableOpacity,
+  Animated,
+  Alert,
+} from 'react-native';
+import Icon from 'react-native-vector-icons/MaterialIcons';
+import {
+  culturalWords,
+  ghanaianNames,
+  commonPhrases,
+  encouragementMessages,
+} from '../data/ghanaianContent';
+
+const SentenceBuilderScreen = () => {
+  const [selectedWords, setSelectedWords] = useState([]);
+  const [currentLevel, setCurrentLevel] = useState(1);
+  const [completedSentences, setCompletedSentences] = useState([]);
+  const [showHint, setShowHint] = useState(false);
+  const animatedValue = useRef(new Animated.Value(0)).current;
+
+  // Sample sentence templates for different levels
+  const sentenceTemplates = [
+    // Level 1: Simple sentences
+    {
+      level: 1,
+      template: ['I', 'like', '___'],
+      hint: 'Choose a Ghanaian food you like!',
+      correctWords: culturalWords.find(cat => cat.category === 'Food').words,
+      examples: ['I like Banku', 'I like Fufu', 'I like Jollof'],
+    },
+    {
+      level: 1,
+      template: ['___', 'is', 'my', 'friend'],
+      hint: 'Choose a Ghanaian name!',
+      correctWords: ghanaianNames,
+      examples: ['Kofi is my friend', 'Ama is my friend', 'Yaw is my friend'],
+    },
+    // Level 2: More complex sentences
+    {
+      level: 2,
+      template: ['My', 'name', 'is', '___', 'and', 'I', 'live', 'in', '___'],
+      hint: 'Choose your name and a Ghanaian city!',
+      correctWords: [...ghanaianNames, ...culturalWords.find(cat => cat.category === 'Places').words],
+      examples: ['My name is Kwame and I live in Accra', 'My name is Efua and I live in Kumasi'],
+    },
+    // Level 3: Cultural sentences
+    {
+      level: 3,
+      template: ['In', 'Ghana,', 'we', 'eat', '___', 'and', 'dance', 'to', '___'],
+      hint: 'Choose a food and something musical!',
+      correctWords: [...culturalWords.find(cat => cat.category === 'Food').words, 'drumming', 'music', 'highlife'],
+      examples: ['In Ghana, we eat Jollof and dance to drumming'],
+    },
+  ];
+
+  const [currentTemplate, setCurrentTemplate] = useState(sentenceTemplates[0]);
+  const [availableWords, setAvailableWords] = useState([]);
+
+  React.useEffect(() => {
+    generateAvailableWords();
+  }, [currentTemplate]);
+
+  const generateAvailableWords = () => {
+    // Mix correct words with some random words from other categories
+    const allCategoryWords = culturalWords.flatMap(cat => cat.words);
+    const randomWords = allCategoryWords.filter(word => 
+      !currentTemplate.correctWords.includes(word)
+    ).slice(0, 6);
+    
+    const words = [...currentTemplate.correctWords.slice(0, 4), ...randomWords]
+      .sort(() => Math.random() - 0.5);
+    
+    setAvailableWords(words);
+    setSelectedWords([]);
+  };
+
+  const selectWord = (word, index) => {
+    const blanksCount = currentTemplate.template.filter(item => item === '___').length;
+    
+    if (selectedWords.length < blanksCount) {
+      setSelectedWords([...selectedWords, word]);
+      setAvailableWords(availableWords.filter((_, i) => i !== index));
+      
+      // Animate selection
+      Animated.spring(animatedValue, {
+        toValue: 1,
+        friction: 3,
+        useNativeDriver: true,
+      }).start(() => {
+        animatedValue.setValue(0);
+      });
+    }
+  };
+
+  const removeWord = (index) => {
+    const word = selectedWords[index];
+    setSelectedWords(selectedWords.filter((_, i) => i !== index));
+    setAvailableWords([...availableWords, word]);
+  };
+
+  const buildSentence = () => {
+    let wordIndex = 0;
+    return currentTemplate.template.map(item => {
+      if (item === '___') {
+        return selectedWords[wordIndex++] || '___';
+      }
+      return item;
+    }).join(' ');
+  };
+
+  const checkSentence = () => {
+    const builtSentence = buildSentence();
+    const hasAllWords = !builtSentence.includes('___');
+    
+    if (hasAllWords) {
+      const encouragement = encouragementMessages[
+        Math.floor(Math.random() * encouragementMessages.length)
+      ];
+      
+      Alert.alert(
+        'Ayɛ! Great Sentence! 🎉',
+        `${encouragement}\n\nYour sentence: "${builtSentence}"\n\nThat makes perfect sense!`,
+        [
+          {
+            text: 'Next Challenge',
+            onPress: nextChallenge,
+          },
+        ]
+      );
+      
+      setCompletedSentences([...completedSentences, builtSentence]);
+    } else {
+      Alert.alert(
+        'Almost there! 💪',
+        'Please fill in all the blanks to complete your sentence.',
+        [{text: 'OK'}]
+      );
+    }
+  };
+
+  const nextChallenge = () => {
+    const availableTemplates = sentenceTemplates.filter(t => t.level <= currentLevel);
+    const randomTemplate = availableTemplates[Math.floor(Math.random() * availableTemplates.length)];
+    setCurrentTemplate(randomTemplate);
+  };
+
+  const levelUp = () => {
+    if (currentLevel < 3) {
+      setCurrentLevel(currentLevel + 1);
+      Alert.alert(
+        'Level Up! 🚀',
+        `Congratulations! You've reached Level ${currentLevel + 1}. The sentences will be more challenging now!`,
+        [{text: 'Let\'s go!', onPress: nextChallenge}]
+      );
+    }
+  };
+
+  const reset = () => {
+    setAvailableWords([...availableWords, ...selectedWords]);
+    setSelectedWords([]);
+  };
+
+  const WordButton = ({word, onPress, isSelected = false}) => (
+    <TouchableOpacity
+      style={[
+        styles.wordButton,
+        isSelected && styles.selectedWordButton,
+      ]}
+      onPress={onPress}>
+      <Text style={[
+        styles.wordButtonText,
+        isSelected && styles.selectedWordButtonText,
+      ]}>
+        {word}
+      </Text>
+    </TouchableOpacity>
+  );
+
+  const renderSentenceBuilder = () => {
+    let wordIndex = 0;
+    return currentTemplate.template.map((item, index) => {
+      if (item === '___') {
+        const currentWordIndex = wordIndex++;
+        return (
+          <TouchableOpacity
+            key={index}
+            style={styles.wordSlot}
+            onPress={() => selectedWords[currentWordIndex] && removeWord(currentWordIndex)}>
+            {selectedWords[currentWordIndex] ? (
+              <Animated.Text
+                style={[
+                  styles.slotWordText,
+                  {
+                    transform: [
+                      {
+                        scale: animatedValue.interpolate({
+                          inputRange: [0, 1],
+                          outputRange: [1, 1.1],
+                        }),
+                      },
+                    ],
+                  },
+                ]}>
+                {selectedWords[currentWordIndex]}
+              </Animated.Text>
+            ) : (
+              <Text style={styles.slotPlaceholder}>___</Text>
+            )}
+          </TouchableOpacity>
+        );
+      }
+      return (
+        <Text key={index} style={styles.templateWord}>
+          {item}
+        </Text>
+      );
+    });
+  };
+
+  return (
+    <ScrollView style={styles.container}>
+      <View style={styles.header}>
+        <Text style={styles.title}>Build Sentences</Text>
+        <Text style={styles.subtitle}>
+          Create meaningful sentences with Ghanaian words!
+        </Text>
+        <View style={styles.levelBadge}>
+          <Text style={styles.levelText}>Level {currentLevel}</Text>
+        </View>
+      </View>
+
+      {/* Current Challenge */}
+      <View style={styles.challengeSection}>
+        <Text style={styles.challengeTitle}>Complete this sentence:</Text>
+        <View style={styles.sentenceBuilder}>
+          {renderSentenceBuilder()}
+        </View>
+        
+        {showHint && (
+          <View style={styles.hintBox}>
+            <Text style={styles.hintText}>{currentTemplate.hint}</Text>
+          </View>
+        )}
+        
+        <TouchableOpacity
+          style={styles.hintButton}
+          onPress={() => setShowHint(!showHint)}>
+          <Icon name={showHint ? 'visibility-off' : 'lightbulb-outline'} size={16} color="#FF6B35" />
+          <Text style={styles.hintButtonText}>
+            {showHint ? 'Hide Hint' : 'Show Hint'}
+          </Text>
+        </TouchableOpacity>
+      </View>
+
+      {/* Available Words */}
+      <View style={styles.wordsSection}>
+        <Text style={styles.wordsTitle}>Choose words to complete the sentence:</Text>
+        <View style={styles.wordsGrid}>
+          {availableWords.map((word, index) => (
+            <WordButton
+              key={`${word}-${index}`}
+              word={word}
+              onPress={() => selectWord(word, index)}
+            />
+          ))}
+        </View>
+      </View>
+
+      {/* Action Buttons */}
+      <View style={styles.actionsSection}>
+        <TouchableOpacity
+          style={[styles.actionButton, styles.checkButton]}
+          onPress={checkSentence}>
+          <Icon name="check" size={20} color="#FFF" />
+          <Text style={styles.actionButtonText}>Check Sentence</Text>
+        </TouchableOpacity>
+
+        <TouchableOpacity
+          style={[styles.actionButton, styles.resetButton]}
+          onPress={reset}>
+          <Icon name="refresh" size={20} color="#FFF" />
+          <Text style={styles.actionButtonText}>Reset</Text>
+        </TouchableOpacity>
+      </View>
+
+      {/* Cultural Phrases Section */}
+      <View style={styles.phrasesSection}>
+        <Text style={styles.phrasesTitle}>Learn Ghanaian Phrases:</Text>
+        {commonPhrases.map((phrase, index) => (
+          <View key={index} style={styles.phraseCard}>
+            <View style={styles.phraseContent}>
+              <Text style={styles.englishText}>{phrase.english}</Text>
+              <Text style={styles.twiText}>{phrase.twi}</Text>
+              <Text style={styles.pronunciationText}>({phrase.pronunciation})</Text>
+            </View>
+            <TouchableOpacity style={styles.speakButton}>
+              <Icon name="volume-up" size={20} color="#FF6B35" />
+            </TouchableOpacity>
+          </View>
+        ))}
+      </View>
+
+      {/* Progress Section */}
+      <View style={styles.progressSection}>
+        <Text style={styles.progressTitle}>Your Completed Sentences:</Text>
+        {completedSentences.map((sentence, index) => (
+          <View key={index} style={styles.completedSentence}>
+            <Text style={styles.sentenceText}>"{sentence}"</Text>
+            <Icon name="check-circle" size={16} color="#4CAF50" />
+          </View>
+        ))}
+        
+        {completedSentences.length >= 3 && currentLevel < 3 && (
+          <TouchableOpacity style={styles.levelUpButton} onPress={levelUp}>
+            <Icon name="arrow-upward" size={20} color="#FFF" />
+            <Text style={styles.levelUpText}>Ready for Level {currentLevel + 1}?</Text>
+          </TouchableOpacity>
+        )}
+      </View>
+    </ScrollView>
+  );
+};
+
+const styles = StyleSheet.create({
+  container: {
+    flex: 1,
+    backgroundColor: '#F8F9FA',
+  },
+  header: {
+    backgroundColor: '#45B7D1',
+    padding: 20,
+    paddingTop: 30,
+    position: 'relative',
+  },
+  title: {
+    fontSize: 24,
+    fontWeight: 'bold',
+    color: '#FFF',
+    textAlign: 'center',
+  },
+  subtitle: {
+    fontSize: 16,
+    color: '#FFF',
+    textAlign: 'center',
+    marginTop: 5,
+    opacity: 0.9,
+  },
+  levelBadge: {
+    position: 'absolute',
+    top: 35,
+    right: 20,
+    backgroundColor: 'rgba(255,255,255,0.2)',
+    borderRadius: 15,
+    paddingHorizontal: 10,
+    paddingVertical: 5,
+  },
+  levelText: {
+    color: '#FFF',
+    fontWeight: 'bold',
+    fontSize: 12,
+  },
+  challengeSection: {
+    backgroundColor: '#FFF',
+    margin: 15,
+    borderRadius: 15,
+    padding: 20,
+    elevation: 2,
+  },
+  challengeTitle: {
+    fontSize: 16,
+    fontWeight: 'bold',
+    color: '#333',
+    marginBottom: 15,
+    textAlign: 'center',
+  },
+  sentenceBuilder: {
+    flexDirection: 'row',
+    flexWrap: 'wrap',
+    justifyContent: 'center',
+    alignItems: 'center',
+    marginBottom: 15,
+  },
+  templateWord: {
+    fontSize: 18,
+    color: '#333',
+    marginHorizontal: 3,
+    marginVertical: 2,
+  },
+  wordSlot: {
+    backgroundColor: '#F0F8FF',
+    borderWidth: 2,
+    borderColor: '#45B7D1',
+    borderStyle: 'dashed',
+    borderRadius: 8,
+    paddingHorizontal: 10,
+    paddingVertical: 8,
+    marginHorizontal: 3,
+    marginVertical: 2,
+    minWidth: 60,
+    alignItems: 'center',
+  },
+  slotWordText: {
+    fontSize: 16,
+    fontWeight: 'bold',
+    color: '#45B7D1',
+  },
+  slotPlaceholder: {
+    fontSize: 16,
+    color: '#CCC',
+  },
+  hintBox: {
+    backgroundColor: '#FFF3CD',
+    borderRadius: 10,
+    padding: 10,
+    marginBottom: 10,
+    borderLeftWidth: 4,
+    borderLeftColor: '#FFC107',
+  },
+  hintText: {
+    fontSize: 14,
+    color: '#856404',
+    textAlign: 'center',
+  },
+  hintButton: {
+    flexDirection: 'row',
+    alignItems: 'center',
+    justifyContent: 'center',
+    paddingVertical: 8,
+  },
+  hintButtonText: {
+    color: '#FF6B35',
+    marginLeft: 5,
+    fontSize: 14,
+    fontWeight: '600',
+  },
+  wordsSection: {
+    padding: 15,
+  },
+  wordsTitle: {
+    fontSize: 16,
+    fontWeight: 'bold',
+    color: '#333',
+    marginBottom: 10,
+  },
+  wordsGrid: {
+    flexDirection: 'row',
+    flexWrap: 'wrap',
+    justifyContent: 'center',
+  },
+  wordButton: {
+    backgroundColor: '#E9ECEF',
+    borderRadius: 10,
+    paddingHorizontal: 12,
+    paddingVertical: 8,
+    margin: 3,
+    borderWidth: 1,
+    borderColor: '#DDD',
+  },
+  selectedWordButton: {
+    backgroundColor: '#45B7D1',
+    borderColor: '#45B7D1',
+  },
+  wordButtonText: {
+    fontSize: 14,
+    fontWeight: '600',
+    color: '#333',
+  },
+  selectedWordButtonText: {
+    color: '#FFF',
+  },
+  actionsSection: {
+    flexDirection: 'row',
+    justifyContent: 'space-around',
+    padding: 15,
+  },
+  actionButton: {
+    flexDirection: 'row',
+    alignItems: 'center',
+    paddingHorizontal: 20,
+    paddingVertical: 12,
+    borderRadius: 25,
+    minWidth: 130,
+    justifyContent: 'center',
+  },
+  checkButton: {
+    backgroundColor: '#4CAF50',
+  },
+  resetButton: {
+    backgroundColor: '#FF6B35',
+  },
+  actionButtonText: {
+    color: '#FFF',
+    fontWeight: 'bold',
+    marginLeft: 5,
+  },
+  phrasesSection: {
+    padding: 15,
+  },
+  phrasesTitle: {
+    fontSize: 16,
+    fontWeight: 'bold',
+    color: '#333',
+    marginBottom: 10,
+  },
+  phraseCard: {
+    backgroundColor: '#FFF',
+    borderRadius: 10,
+    padding: 15,
+    marginBottom: 10,
+    flexDirection: 'row',
+    justifyContent: 'space-between',
+    alignItems: 'center',
+    elevation: 1,
+  },
+  phraseContent: {
+    flex: 1,
+  },
+  englishText: {
+    fontSize: 16,
+    fontWeight: 'bold',
+    color: '#333',
+    marginBottom: 3,
+  },
+  twiText: {
+    fontSize: 14,
+    color: '#FF6B35',
+    fontWeight: '600',
+    marginBottom: 2,
+  },
+  pronunciationText: {
+    fontSize: 12,
+    color: '#666',
+    fontStyle: 'italic',
+  },
+  speakButton: {
+    padding: 8,
+  },
+  progressSection: {
+    padding: 15,
+  },
+  progressTitle: {
+    fontSize: 16,
+    fontWeight: 'bold',
+    color: '#333',
+    marginBottom: 10,
+  },
+  completedSentence: {
+    flexDirection: 'row',
+    alignItems: 'center',
+    backgroundColor: '#E8F5E8',
+    borderRadius: 10,
+    padding: 10,
+    marginBottom: 8,
+  },
+  sentenceText: {
+    flex: 1,
+    fontSize: 14,
+    color: '#4CAF50',
+    fontWeight: '600',
+    marginRight: 10,
+  },
+  levelUpButton: {
+    backgroundColor: '#FF6B35',
+    borderRadius: 25,
+    padding: 15,
+    flexDirection: 'row',
+    alignItems: 'center',
+    justifyContent: 'center',
+    marginTop: 10,
+  },
+  levelUpText: {
+    color: '#FFF',
+    fontWeight: 'bold',
+    marginLeft: 8,
+  },
+});
+
+export default SentenceBuilderScreen; 

diff --git a/src/screens/WordBuilderScreen.js b/src/screens/WordBuilderScreen.js
--- a/src/screens/WordBuilderScreen.js
+++ b/src/screens/WordBuilderScreen.js
@@ -0,0 +1,486 @@
+import React, {useState, useRef} from 'react';
+import {
+  View,
+  Text,
+  StyleSheet,
+  ScrollView,
+  TouchableOpacity,
+  Animated,
+  Alert,
+} from 'react-native';
+import Icon from 'react-native-vector-icons/MaterialIcons';
+import {culturalWords, encouragementMessages} from '../data/ghanaianContent';
+
+const WordBuilderScreen = () => {
+  const [selectedCategory, setSelectedCategory] = useState(culturalWords[0]);
+  const [currentWordIndex, setCurrentWordIndex] = useState(0);
+  const [selectedLetters, setSelectedLetters] = useState([]);
+  const [availableLetters, setAvailableLetters] = useState([]);
+  const [completedWords, setCompletedWords] = useState([]);
+  const animatedValue = useRef(new Animated.Value(0)).current;
+
+  const currentWord = selectedCategory.words[currentWordIndex];
+  const targetLetters = currentWord.toUpperCase().split('');
+
+  React.useEffect(() => {
+    // Generate available letters (target letters + some random ones)
+    const extraLetters = ['X', 'Z', 'Q', 'V', 'W', 'K', 'L', 'M', 'N', 'P'];
+    const allLetters = [
+      ...targetLetters,
+      ...extraLetters.slice(0, Math.max(0, 8 - targetLetters.length)),
+    ];
+    
+    // Shuffle the letters
+    const shuffled = allLetters.sort(() => Math.random() - 0.5);
+    setAvailableLetters(shuffled);
+    setSelectedLetters([]);
+  }, [currentWord]);
+
+  const selectLetter = (letter, index) => {
+    if (selectedLetters.length < targetLetters.length) {
+      setSelectedLetters([...selectedLetters, letter]);
+      setAvailableLetters(availableLetters.filter((_, i) => i !== index));
+      
+      // Animate selection
+      Animated.spring(animatedValue, {
+        toValue: 1,
+        friction: 3,
+        useNativeDriver: true,
+      }).start(() => {
+        animatedValue.setValue(0);
+      });
+    }
+  };
+
+  const removeLetter = (index) => {
+    const letter = selectedLetters[index];
+    setSelectedLetters(selectedLetters.filter((_, i) => i !== index));
+    setAvailableLetters([...availableLetters, letter]);
+  };
+
+  const checkWord = () => {
+    const formedWord = selectedLetters.join('');
+    const isCorrect = formedWord === currentWord.toUpperCase();
+    
+    if (isCorrect) {
+      const encouragement = encouragementMessages[
+        Math.floor(Math.random() * encouragementMessages.length)
+      ];
+      
+      Alert.alert(
+        'Ayɛ! Correct! 🎉',
+        `${encouragement}\n\nYou spelled "${currentWord}" perfectly!`,
+        [
+          {
+            text: 'Next Word',
+            onPress: nextWord,
+          },
+        ]
+      );
+      
+      setCompletedWords([...completedWords, currentWord]);
+    } else {
+      Alert.alert(
+        'Try Again! 💪',
+        `Not quite right. The word is "${currentWord}". Let\'s try again!`,
+        [
+          {
+            text: 'OK',
+            onPress: () => {
+              setSelectedLetters([]);
+              setAvailableLetters(availableLetters.concat(selectedLetters));
+            },
+          },
+        ]
+      );
+    }
+  };
+
+  const nextWord = () => {
+    if (currentWordIndex < selectedCategory.words.length - 1) {
+      setCurrentWordIndex(currentWordIndex + 1);
+    } else {
+      setCurrentWordIndex(0);
+    }
+  };
+
+  const resetWord = () => {
+    setAvailableLetters([...availableLetters, ...selectedLetters]);
+    setSelectedLetters([]);
+  };
+
+  const CategoryCard = ({category, isSelected, onPress}) => (
+    <TouchableOpacity
+      style={[
+        styles.categoryCard,
+        isSelected && styles.selectedCategoryCard,
+      ]}
+      onPress={onPress}>
+      <Text style={[
+        styles.categoryText,
+        isSelected && styles.selectedCategoryText,
+      ]}>
+        {category.category}
+      </Text>
+      <Text style={styles.categoryCount}>
+        {category.words.length} words
+      </Text>
+    </TouchableOpacity>
+  );
+
+  const LetterButton = ({letter, onPress, isTarget = false}) => (
+    <TouchableOpacity
+      style={[
+        styles.letterButton,
+        isTarget && styles.targetLetterButton,
+      ]}
+      onPress={onPress}>
+      <Text style={[
+        styles.letterButtonText,
+        isTarget && styles.targetLetterButtonText,
+      ]}>
+        {letter}
+      </Text>
+    </TouchableOpacity>
+  );
+
+  return (
+    <ScrollView style={styles.container}>
+      <View style={styles.header}>
+        <Text style={styles.title}>Build Ghanaian Words</Text>
+        <Text style={styles.subtitle}>
+          Drag letters to spell words from Ghanaian culture!
+        </Text>
+      </View>
+
+      {/* Category Selection */}
+      <View style={styles.categoriesSection}>
+        <Text style={styles.sectionTitle}>Choose a Category:</Text>
+        <ScrollView horizontal showsHorizontalScrollIndicator={false}>
+          <View style={styles.categoriesContainer}>
+            {culturalWords.map((category, index) => (
+              <CategoryCard
+                key={index}
+                category={category}
+                isSelected={selectedCategory.category === category.category}
+                onPress={() => {
+                  setSelectedCategory(category);
+                  setCurrentWordIndex(0);
+                  setCompletedWords([]);
+                }}
+              />
+            ))}
+          </View>
+        </ScrollView>
+      </View>
+
+      {/* Current Word */}
+      <View style={styles.wordSection}>
+        <Text style={styles.wordTitle}>Spell this word:</Text>
+        <Text style={styles.targetWord}>{currentWord}</Text>
+        <Text style={styles.progressText}>
+          Word {currentWordIndex + 1} of {selectedCategory.words.length}
+        </Text>
+      </View>
+
+      {/* Word Building Area */}
+      <View style={styles.buildingArea}>
+        <Text style={styles.buildingTitle}>Your Word:</Text>
+        <View style={styles.wordSlots}>
+          {targetLetters.map((_, index) => (
+            <TouchableOpacity
+              key={index}
+              style={styles.letterSlot}
+              onPress={() => selectedLetters[index] && removeLetter(index)}>
+              {selectedLetters[index] ? (
+                <Animated.Text
+                  style={[
+                    styles.slotLetterText,
+                    {
+                      transform: [
+                        {
+                          scale: animatedValue.interpolate({
+                            inputRange: [0, 1],
+                            outputRange: [1, 1.2],
+                          }),
+                        },
+                      ],
+                    },
+                  ]}>
+                  {selectedLetters[index]}
+                </Animated.Text>
+              ) : (
+                <Text style={styles.slotPlaceholder}>?</Text>
+              )}
+            </TouchableOpacity>
+          ))}
+        </View>
+      </View>
+
+      {/* Available Letters */}
+      <View style={styles.lettersSection}>
+        <Text style={styles.lettersTitle}>Available Letters:</Text>
+        <View style={styles.lettersGrid}>
+          {availableLetters.map((letter, index) => (
+            <LetterButton
+              key={`${letter}-${index}`}
+              letter={letter}
+              onPress={() => selectLetter(letter, index)}
+              isTarget={targetLetters.includes(letter)}
+            />
+          ))}
+        </View>
+      </View>
+
+      {/* Action Buttons */}
+      <View style={styles.actionsSection}>
+        <TouchableOpacity
+          style={[styles.actionButton, styles.checkButton]}
+          onPress={checkWord}
+          disabled={selectedLetters.length !== targetLetters.length}>
+          <Icon name="check" size={20} color="#FFF" />
+          <Text style={styles.actionButtonText}>Check Word</Text>
+        </TouchableOpacity>
+
+        <TouchableOpacity
+          style={[styles.actionButton, styles.resetButton]}
+          onPress={resetWord}>
+          <Icon name="refresh" size={20} color="#FFF" />
+          <Text style={styles.actionButtonText}>Reset</Text>
+        </TouchableOpacity>
+      </View>
+
+      {/* Progress Section */}
+      <View style={styles.progressSection}>
+        <Text style={styles.progressTitle}>Completed Words:</Text>
+        <View style={styles.completedWords}>
+          {completedWords.map((word, index) => (
+            <View key={index} style={styles.completedWordChip}>
+              <Text style={styles.completedWordText}>{word}</Text>
+              <Icon name="check-circle" size={16} color="#4CAF50" />
+            </View>
+          ))}
+        </View>
+      </View>
+    </ScrollView>
+  );
+};
+
+const styles = StyleSheet.create({
+  container: {
+    flex: 1,
+    backgroundColor: '#F8F9FA',
+  },
+  header: {
+    backgroundColor: '#4ECDC4',
+    padding: 20,
+    paddingTop: 30,
+  },
+  title: {
+    fontSize: 24,
+    fontWeight: 'bold',
+    color: '#FFF',
+    textAlign: 'center',
+  },
+  subtitle: {
+    fontSize: 16,
+    color: '#FFF',
+    textAlign: 'center',
+    marginTop: 5,
+    opacity: 0.9,
+  },
+  categoriesSection: {
+    padding: 15,
+  },
+  sectionTitle: {
+    fontSize: 18,
+    fontWeight: 'bold',
+    color: '#333',
+    marginBottom: 10,
+  },
+  categoriesContainer: {
+    flexDirection: 'row',
+  },
+  categoryCard: {
+    backgroundColor: '#FFF',
+    borderRadius: 15,
+    padding: 15,
+    marginRight: 10,
+    minWidth: 100,
+    alignItems: 'center',
+    borderWidth: 2,
+    borderColor: '#E9ECEF',
+  },
+  selectedCategoryCard: {
+    borderColor: '#4ECDC4',
+    backgroundColor: '#E8F8F7',
+  },
+  categoryText: {
+    fontSize: 14,
+    fontWeight: 'bold',
+    color: '#333',
+    textAlign: 'center',
+  },
+  selectedCategoryText: {
+    color: '#4ECDC4',
+  },
+  categoryCount: {
+    fontSize: 12,
+    color: '#666',
+    marginTop: 3,
+  },
+  wordSection: {
+    backgroundColor: '#FFF',
+    margin: 15,
+    borderRadius: 15,
+    padding: 20,
+    alignItems: 'center',
+    elevation: 2,
+  },
+  wordTitle: {
+    fontSize: 16,
+    color: '#666',
+    marginBottom: 10,
+  },
+  targetWord: {
+    fontSize: 28,
+    fontWeight: 'bold',
+    color: '#333',
+    marginBottom: 5,
+  },
+  progressText: {
+    fontSize: 14,
+    color: '#888',
+  },
+  buildingArea: {
+    backgroundColor: '#FFF',
+    margin: 15,
+    borderRadius: 15,
+    padding: 20,
+    elevation: 2,
+  },
+  buildingTitle: {
+    fontSize: 16,
+    fontWeight: 'bold',
+    color: '#333',
+    marginBottom: 15,
+    textAlign: 'center',
+  },
+  wordSlots: {
+    flexDirection: 'row',
+    justifyContent: 'center',
+    flexWrap: 'wrap',
+  },
+  letterSlot: {
+    width: 50,
+    height: 50,
+    borderWidth: 2,
+    borderColor: '#DDD',
+    borderRadius: 10,
+    margin: 3,
+    justifyContent: 'center',
+    alignItems: 'center',
+    backgroundColor: '#F8F9FA',
+  },
+  slotLetterText: {
+    fontSize: 24,
+    fontWeight: 'bold',
+    color: '#333',
+  },
+  slotPlaceholder: {
+    fontSize: 20,
+    color: '#CCC',
+  },
+  lettersSection: {
+    padding: 15,
+  },
+  lettersTitle: {
+    fontSize: 16,
+    fontWeight: 'bold',
+    color: '#333',
+    marginBottom: 10,
+  },
+  lettersGrid: {
+    flexDirection: 'row',
+    flexWrap: 'wrap',
+    justifyContent: 'center',
+  },
+  letterButton: {
+    width: 45,
+    height: 45,
+    backgroundColor: '#E9ECEF',
+    borderRadius: 10,
+    margin: 3,
+    justifyContent: 'center',
+    alignItems: 'center',
+    borderWidth: 1,
+    borderColor: '#DDD',
+  },
+  targetLetterButton: {
+    backgroundColor: '#FFE4E1',
+    borderColor: '#FF6B35',
+  },
+  letterButtonText: {
+    fontSize: 18,
+    fontWeight: 'bold',
+    color: '#333',
+  },
+  targetLetterButtonText: {
+    color: '#FF6B35',
+  },
+  actionsSection: {
+    flexDirection: 'row',
+    justifyContent: 'space-around',
+    padding: 15,
+  },
+  actionButton: {
+    flexDirection: 'row',
+    alignItems: 'center',
+    paddingHorizontal: 20,
+    paddingVertical: 12,
+    borderRadius: 25,
+    minWidth: 120,
+    justifyContent: 'center',
+  },
+  checkButton: {
+    backgroundColor: '#4CAF50',
+  },
+  resetButton: {
+    backgroundColor: '#FF6B35',
+  },
+  actionButtonText: {
+    color: '#FFF',
+    fontWeight: 'bold',
+    marginLeft: 5,
+  },
+  progressSection: {
+    padding: 15,
+  },
+  progressTitle: {
+    fontSize: 16,
+    fontWeight: 'bold',
+    color: '#333',
+    marginBottom: 10,
+  },
+  completedWords: {
+    flexDirection: 'row',
+    flexWrap: 'wrap',
+  },
+  completedWordChip: {
+    flexDirection: 'row',
+    alignItems: 'center',
+    backgroundColor: '#E8F5E8',
+    borderRadius: 15,
+    paddingHorizontal: 10,
+    paddingVertical: 5,
+    margin: 3,
+  },
+  completedWordText: {
+    fontSize: 14,
+    color: '#4CAF50',
+    fontWeight: '600',
+    marginRight: 5,
+  },
+});
+
+export default WordBuilderScreen; 
diff --git a/src/utils/soundManager.js b/src/utils/soundManager.js
--- a/src/utils/soundManager.js
+++ b/src/utils/soundManager.js
@@ -0,0 +1,80 @@
+// Sound management utility for letter sounds and audio feedback
+// In a production app, this would integrate with react-native-sound or similar library
+
+class SoundManager {
+  constructor() {
+    this.sounds = new Map();
+    this.isEnabled = true;
+  }
+
+  // Load sound files (placeholder for real implementation)
+  loadSounds() {
+    // In a real app, you would load actual audio files here
+    const letterSounds = [
+      'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j',
+      'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't',
+      'u', 'v', 'w', 'x', 'y', 'z'
+    ];
+
+    letterSounds.forEach(letter => {
+      // Placeholder for sound loading
+      this.sounds.set(letter, `sounds/${letter}.mp3`);
+    });
+  }
+
+  // Play letter sound
+  playLetterSound(letter) {
+    if (!this.isEnabled) return;
+    
+    try {
+      console.log(`Playing sound for letter: ${letter}`);
+      // In a real implementation:
+      // const sound = this.sounds.get(letter.toLowerCase());
+      // if (sound) {
+      //   sound.play();
+      // }
+    } catch (error) {
+      console.warn('Failed to play sound:', error);
+    }
+  }
+
+  // Play word pronunciation
+  playWordSound(word) {
+    if (!this.isEnabled) return;
+    
+    try {
+      console.log(`Playing pronunciation for word: ${word}`);
+      // In a real implementation, this would play the word pronunciation
+    } catch (error) {
+      console.warn('Failed to play word sound:', error);
+    }
+  }
+
+  // Play success/feedback sounds
+  playFeedbackSound(type = 'success') {
+    if (!this.isEnabled) return;
+    
+    try {
+      console.log(`Playing ${type} feedback sound`);
+      // Types: 'success', 'error', 'click', 'complete'
+    } catch (error) {
+      console.warn('Failed to play feedback sound:', error);
+    }
+  }
+
+  // Toggle sound on/off
+  toggleSound() {
+    this.isEnabled = !this.isEnabled;
+    console.log(`Sound ${this.isEnabled ? 'enabled' : 'disabled'}`);
+    return this.isEnabled;
+  }
+
+  // Set volume (0-1)
+  setVolume(volume) {
+    this.volume = Math.max(0, Math.min(1, volume));
+    console.log(`Volume set to: ${this.volume * 100}%`);
+  }
+}
+
+// Export singleton instance
+export default new SoundManager(); 
diff --git a/src/utils/storage.js b/src/utils/storage.js
--- a/src/utils/storage.js
+++ b/src/utils/storage.js
@@ -0,0 +1,256 @@
+// Storage utility for managing user progress and app data
+// Uses AsyncStorage for persistent data storage
+
+import AsyncStorage from '@react-native-async-storage/async-storage';
+
+class StorageManager {
+  constructor() {
+    this.keys = {
+      USER_PROGRESS: 'userProgress',
+      SETTINGS: 'appSettings',
+      ACHIEVEMENTS: 'userAchievements',
+      COMPLETED_WORDS: 'completedWords',
+      COMPLETED_SENTENCES: 'completedSentences',
+      GAME_SCORES: 'gameScores',
+      DAILY_STREAK: 'dailyStreak',
+      LAST_ACTIVITY_DATE: 'lastActivityDate'
+    };
+  }
+
+  // Generic storage methods
+  async setItem(key, value) {
+    try {
+      const jsonValue = JSON.stringify(value);
+      await AsyncStorage.setItem(key, jsonValue);
+      return true;
+    } catch (error) {
+      console.error('Error saving data:', error);
+      return false;
+    }
+  }
+
+  async getItem(key, defaultValue = null) {
+    try {
+      const jsonValue = await AsyncStorage.getItem(key);
+      return jsonValue != null ? JSON.parse(jsonValue) : defaultValue;
+    } catch (error) {
+      console.error('Error reading data:', error);
+      return defaultValue;
+    }
+  }
+
+  async removeItem(key) {
+    try {
+      await AsyncStorage.removeItem(key);
+      return true;
+    } catch (error) {
+      console.error('Error removing data:', error);
+      return false;
+    }
+  }
+
+  // User progress methods
+  async saveUserProgress(progress) {
+    return await this.setItem(this.keys.USER_PROGRESS, progress);
+  }
+
+  async getUserProgress() {
+    const defaultProgress = {
+      lettersLearned: 0,
+      wordsCompleted: 0,
+      sentencesBuilt: 0,
+      gamesPlayed: 0,
+      totalScore: 0,
+      timeSpent: 0,
+      level: 1,
+      currentStreak: 0,
+      bestStreak: 0
+    };
+    
+    return await this.getItem(this.keys.USER_PROGRESS, defaultProgress);
+  }
+
+  // Achievements methods
+  async saveAchievements(achievements) {
+    return await this.setItem(this.keys.ACHIEVEMENTS, achievements);
+  }
+
+  async getAchievements() {
+    const defaultAchievements = [];
+    return await this.getItem(this.keys.ACHIEVEMENTS, defaultAchievements);
+  }
+
+  async unlockAchievement(achievementId) {
+    const achievements = await this.getAchievements();
+    if (!achievements.includes(achievementId)) {
+      achievements.push(achievementId);
+      await this.saveAchievements(achievements);
+      return true;
+    }
+    return false;
+  }
+
+  // Completed words tracking
+  async saveCompletedWords(words) {
+    return await this.setItem(this.keys.COMPLETED_WORDS, words);
+  }
+
+  async getCompletedWords() {
+    return await this.getItem(this.keys.COMPLETED_WORDS, []);
+  }
+
+  async addCompletedWord(word) {
+    const completedWords = await this.getCompletedWords();
+    if (!completedWords.includes(word)) {
+      completedWords.push(word);
+      await this.saveCompletedWords(completedWords);
+      
+      // Update user progress
+      const progress = await this.getUserProgress();
+      progress.wordsCompleted = completedWords.length;
+      await this.saveUserProgress(progress);
+      
+      return true;
+    }
+    return false;
+  }
+
+  // Completed sentences tracking
+  async saveCompletedSentences(sentences) {
+    return await this.setItem(this.keys.COMPLETED_SENTENCES, sentences);
+  }
+
+  async getCompletedSentences() {
+    return await this.getItem(this.keys.COMPLETED_SENTENCES, []);
+  }
+
+  async addCompletedSentence(sentence) {
+    const completedSentences = await this.getCompletedSentences();
+    completedSentences.push({
+      sentence,
+      date: new Date().toISOString(),
+      timestamp: Date.now()
+    });
+    
+    await this.saveCompletedSentences(completedSentences);
+    
+    // Update user progress
+    const progress = await this.getUserProgress();
+    progress.sentencesBuilt = completedSentences.length;
+    await this.saveUserProgress(progress);
+    
+    return true;
+  }
+
+  // Daily streak management
+  async updateDailyStreak() {
+    const today = new Date().toDateString();
+    const lastActivityDate = await this.getItem(this.keys.LAST_ACTIVITY_DATE);
+    const currentStreak = await this.getItem(this.keys.DAILY_STREAK, 0);
+    
+    if (lastActivityDate !== today) {
+      const yesterday = new Date();
+      yesterday.setDate(yesterday.getDate() - 1);
+      
+      let newStreak;
+      if (lastActivityDate === yesterday.toDateString()) {
+        // Consecutive day
+        newStreak = currentStreak + 1;
+      } else {
+        // Streak broken
+        newStreak = 1;
+      }
+      
+      await this.setItem(this.keys.DAILY_STREAK, newStreak);
+      await this.setItem(this.keys.LAST_ACTIVITY_DATE, today);
+      
+      // Update progress
+      const progress = await this.getUserProgress();
+      progress.currentStreak = newStreak;
+      progress.bestStreak = Math.max(progress.bestStreak, newStreak);
+      await this.saveUserProgress(progress);
+      
+      return newStreak;
+    }
+    
+    return currentStreak;
+  }
+
+  // App settings
+  async saveSettings(settings) {
+    return await this.setItem(this.keys.SETTINGS, settings);
+  }
+
+  async getSettings() {
+    const defaultSettings = {
+      soundEnabled: true,
+      volume: 0.8,
+      language: 'en',
+      showHints: true,
+      difficulty: 'easy'
+    };
+    
+    return await this.getItem(this.keys.SETTINGS, defaultSettings);
+  }
+
+  // Game scores
+  async saveGameScore(gameType, score) {
+    const scores = await this.getItem(this.keys.GAME_SCORES, {});
+    
+    if (!scores[gameType]) {
+      scores[gameType] = [];
+    }
+    
+    scores[gameType].push({
+      score,
+      date: new Date().toISOString(),
+      timestamp: Date.now()
+    });
+    
+    // Keep only the last 10 scores per game
+    scores[gameType] = scores[gameType].slice(-10);
+    
+    return await this.setItem(this.keys.GAME_SCORES, scores);
+  }
+
+  async getGameScores(gameType = null) {
+    const scores = await this.getItem(this.keys.GAME_SCORES, {});
+    return gameType ? scores[gameType] || [] : scores;
+  }
+
+  // Clear all data (for reset functionality)
+  async clearAllData() {
+    try {
+      await AsyncStorage.clear();
+      console.log('All data cleared successfully');
+      return true;
+    } catch (error) {
+      console.error('Error clearing data:', error);
+      return false;
+    }
+  }
+
+  // Export data for backup
+  async exportData() {
+    try {
+      const allData = {
+        progress: await this.getUserProgress(),
+        achievements: await this.getAchievements(),
+        completedWords: await this.getCompletedWords(),
+        completedSentences: await this.getCompletedSentences(),
+        settings: await this.getSettings(),
+        gameScores: await this.getGameScores(),
+        dailyStreak: await this.getItem(this.keys.DAILY_STREAK, 0),
+        exportDate: new Date().toISOString()
+      };
+      
+      return allData;
+    } catch (error) {
+      console.error('Error exporting data:', error);
+      return null;
+    }
+  }
+}
+
+// Export singleton instance
+export default new StorageManager();
+
