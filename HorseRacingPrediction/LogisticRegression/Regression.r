# Load the data and take a look at it.
data <- read.csv("C:\\Users\\Gary\\Documents\\Presentations\\SoftwareArchitect\\HorseRacingPrediction\\LogisticRegression\\Data.csv");
head(data);

# Predict win/lose based on mile time and weight
logit <- glm(Win~MileTime+Weight, data=data, family="binomial");

summary(logit);

# "Decode" the coefficients
exp(coef(logit))