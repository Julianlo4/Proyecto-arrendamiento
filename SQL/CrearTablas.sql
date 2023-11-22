DROP TABLE REGISTRO;
CREATE TABLE registro(
    RegId number(10, 0),
    RegPrimerNom varchar2(100) not null,
    RegSegundoNom varchar2(100),
    RegPrimerApe varchar2(100) not null,
    RegSegundoApe varchar2(100),
    RegNombreU varchar2(60),
    RegFechaNac date not null,
    RegGenero varchar2(30) not null check (RegGenero in ('Femenino', 'Masculino', 'Otro', 'Desconocido')),
    RegTelefono varchar2(15) not null,
    RegCorreo varchar2(50) not null,
    RegAspArrendador number(1) default 0 ,
    RegAspArrendatario number(1) default 0,
    RegContrasenia varchar2(50) not null,
    constraint pk_Registro primary key (RegId),
    constraint uq_RegTelefono unique (RegTelefono),
    constraint uq_RegCorreo unique (RegCorreo)
);

DROP TABLE inmueble;
CREATE TABLE inmueble(    
    RegId number(10),
    InmId number(30),    
    InmTitulo varchar2(100) not null,
    InmUbicacion varchar2(10) not null,
    InmDireccion varchar2(20) not null,
    InmTelefono varchar2(10) not null,
    InmSerAgua number(1) default 0,    
    InmSerLuz number(1) default 0,
    InmSerWifi number(1) default 0,    
    InmSerTv number(1) default 0,
    InmSerLavadora number(1) default 0,    
    InmSerGas number(1) default 0,
    InmPrecio number(10) not null,    
    InmDescripcion varchar2(300),
    InmTipoVivienda varchar2(50) not null,    
    InmAmoblado number(1) default 0,
    InmAnimales number(1) default 0,    
    InmParqueadero varchar2(40),
    constraint ckc_InmParqueadero check (InmParqueadero in('Parqueadero para carro', 'Paqueadero para moto', 'Parqueadero para carro y moto', 'No tengo parqueadero')),    
    constraint ckc_InmTipoVivienda check (InmTipoVivienda in('Habitacion', 'Apartamento', 'Casa', 'Apartaestudio', 'Otro')),
    constraint fk_RegInm foreign key (RegId) references registro(RegId),    
    constraint pk_Inmueble primary key (InmId),
    constraint ckc_InmUbicacion check (InmUbicacion in('Centro', 'Sur', 'Norte', 'Oriente', 'Occidente')),    
    constraint ckc_InmPrecio check (InmPrecio > 0)
);

DROP TABLE comentario_resenia;
CREATE TABLE comentario_resenia(    
    CRId number(30),
    RegId number(10),    
    InmId number(30),
    CRCalificacion number(1) not null,    
    CRResenia varchar2(500),
    constraint pk_Comentario_resenia primary key (CRId),    
    constraint ckc_CRCalificacion check (CRCalificacion between 1 and 5)
);

DROP TABLE solicitud;
CREATE TABLE solicitud(    
    SolId number(30),
    RegId number(10),    
    InmId number(30)
);

CREATE SEQUENCE inmueble_seq
    START WITH 1
    INCREMENT BY 1
    NOMAXVALUE
    NOCACHE
    NOCYCLE;
    
CREATE OR REPLACE TRIGGER tgr_generate_inmid
BEFORE INSERT ON inmueble
FOR EACH ROW
BEGIN
    SELECT inmueble_seq.NEXTVAL INTO :NEW.inmID FROM dual;
END;


