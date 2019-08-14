pipeline { 
    agent any
    stages {
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