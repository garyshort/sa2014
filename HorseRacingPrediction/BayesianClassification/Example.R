#Load the library
library('e1071')

#Load test data
trainingData <- read.csv('C:\\Users\\Gary\\Documents\\Presentations\\SoftwareArchitect\\HorseRacingPrediction\\BayesianClassification\\Data.csv')

#Build a model
model <- naiveBayes(Win~., data=trainingData)

#Load the test data
testData <- read.csv('C:\\Users\\Gary\\Documents\\Presentations\\SoftwareArchitect\\HorseRacingPrediction\\BayesianClassification\\Test.csv')

#Predict the test data
pred <- predict(model, testData);
table(pred, testData[,1]);





