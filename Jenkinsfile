pipeline { 
    agent any 
    options {
        skipStagesAfterUnstable()
    }
    stages {
        stage('Example') {
            steps {
                echo 'Hello World Testing jenkins file'
            }
        }
		stage('Build') { 
            steps { 
                sh 'dotnet build -p:Configuration=Release' 
            }
        }
        stage('Test'){
            steps {
                sh 'dotnet test'
            }
        }
    }
}