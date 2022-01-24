# ==============================================================================================================================================================================================================================================
# Build: docker build -t andrewtait/lt510d .
# Run: docker run -d -p 8558:8888 --name lt510d andrewtait/lt510d
# ==============================================================================================================================================================================================================================================

FROM mcr.microsoft.com/dotnet/sdk:6.0
LABEL maintainer="Andrew Tait <Andrew.Tait@decisionmechanics.com>"

ARG PATH="/root/miniconda3/bin:${PATH}"
ENV PATH="/root/miniconda3/bin:${PATH}"

RUN apt-get update && apt-get install -y wget && rm -rf /var/lib/apt/lists/*

RUN wget \
    https://repo.anaconda.com/miniconda/Miniconda3-latest-Linux-x86_64.sh \
    && mkdir /root/.conda \
    && bash Miniconda3-latest-Linux-x86_64.sh -b \
    && rm -f Miniconda3-latest-Linux-x86_64.sh

RUN conda install -c conda-forge jupyterlab
RUN conda install -c anaconda cmake -y

RUN dotnet tool install -g Microsoft.dotnet-interactive

ENV PATH="${PATH}:/root/.dotnet/tools"

RUN dotnet interactive jupyter install

RUN conda install -c conda-forge jupyterlab-plotly-extension
RUN pip install jupyterlab_darkside_ui

EXPOSE 8888

RUN mkdir /data
WORKDIR /data

RUN mkdir /data/exercises
COPY exercises /data/exercises

ENTRYPOINT ["jupyter", "lab", "--ip=0.0.0.0", "--allow-root", "--NotebookApp.password='sha1:45de6457d836:0bc06809ba1eed4e1d52748ded3bed1ac877e414'"]

