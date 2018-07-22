
exec=app
outDirectory=out
commitHash=${CI_COMMIT_SHA}
version=${CI_COMMIT_TAG}
.PHONY: all

run: 
	dotnet restore
	dotnet run  --project App
configure:
	dotnet restore
test: configure
	dotnet test ./Test
build: clean
	dotnet publish -c Release -o ${out}
	rm -f 
build-docker:
	docker build -t  dummy3d:latest .
clean:
	rm -f ${out}
