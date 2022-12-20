create table patient(p_code varchar(20) primary key, p_name varchar(10), p_birth varchar(6), p_phonenumber varchar(11), p_address varchar(100), p_protector varchar(10), p_accident varchar(100), p_sex char(6), p_register varchar(20), d_code varchar(20))
/
create table doctor(d_code varchar(20) primary key, d_name varchar(20), d_phonenumber varchar(11), d_major varchar(20), d_email varchar(100), d_rest varchar(20))
/
create table nurse(n_code varchar(20) primary key, n_mainwork varchar(20), n_name varchar(10), n_sex varchar(6), n_phonenumber varchar(11), n_email varchar(100), n_position varchar(20), n_rest varchar(20))
/
create table treatment(t_code varchar(20) primary key, t_information varchar(100), t_date varchar(20), p_code varchar(20), d_code varchar(20))
/
create table chart(c_code varchar(20) primary key, c_opinion varchar(100), t_code varchar(20), p_code varchar(20), d_code varchar(20), n_code varchar(20))
/
alter table patient add foreign key (d_code) references doctor (d_code)
/
alter table treatment add foreign key (p_code) references patient (p_code)
/
alter table treatment add foreign key (d_code) references doctor (d_code)
/
alter table chart add foreign key (d_code) references doctor (d_code)
/
alter table chart add foreign key (t_code) references treatment (t_code)
/
alter table chart add foreign key (p_code) references patient (p_code)
/
alter table chart add foreign key (n_code) references nurse (n_code)
/
insert into doctor values('DR192', '�տ���', '01028171924', '���к��', 'djnoa12@naver.com', '��')
/
insert into doctor values('DR102', '������', '01010583829', '�����ܰ�', 'cbnwi32@naver.com', 'ȭ')
/
insert into doctor values('DR744', '�̿���', '01054629124', '�����', 'vnqox98@naver.com', '��')
/
insert into doctor values('DR264', '������', '01093712943', '����', 'vnqos34@naver.com', '��')
/
insert into doctor values('DR674', '�����', '01048102947', '��οܰ�', 'vnqox98@naver.com', '��')
/
insert into doctor values('DR245', '�輺��', '01029571023', '����ΰ�', 'vnqos34@naver.com', 'ȭ')
/
insert into nurse values('NU132', '����óġ', '������', '����', '01092614912', 'cnos12@naver.com', '��ȣ����', '��')
/
insert into nurse values('NU152', '����óġ', '������', '����', '01037107323', 'gnwoz1412@naver.com', '����ȣ��', 'ȭ')
/
insert into nurse values('NU856', '��ȯ�ڰ���', '�����', '����', '01084612905', 'fanzo21@naver.com', '���Ӱ�ȣ��', '��')
/
insert into nurse values('NU301', '����ũ����', '�̽���', '����', '01044930243', 'jsb0274@naver.com', '�ű԰�ȣ��', '��')
/
insert into nurse values('NU631', '��ǰ����', '�׻���', '����', '01092712413', 'cnwo912@naver.com', '�ű԰�ȣ��', '��')
/
insert into nurse values('NU912', '�������', '¥����', '����', '01088172019', 'resnoc092@naver.com', '�ű԰�ȣ��', '��')
/
insert into patient values ('PA123', '��ö��', '970412', '01029471024', '����� �����', 'ȫ�浿', '������', '����', 20220712, 'DR192')
/
insert into patient values('PA456', '�̿���', '991023', '01038192853', '����� �߶���', '�庸��', '������', '����', 20220810, 'DR102')
/
insert into patient values('PA789', '��¯��', '980916', '01081243617', '����� ���빮��', '¯����', '������', '����', 20220521, 'DR744')
/
insert into patient values('PA012', '��¯��', '960123', '01005729461', '����� ���α�', '¯����', 'ȭ����', '����', 20211102, 'DR264')
/
insert into treatment values('TM018', 'MRI', '20221201', 'PA123', 'DR192')
/
insert into treatment values('TM213', 'MRI', '20221210', 'PA456', 'DR102')
/
insert into treatment values('TM856', 'CT', '20221208', 'PA789', 'DR744')
/
insert into treatment values('TM991', 'Bloodtest', '20221215', 'PA012', 'DR264')
/
insert into chart values('CH102', 'neurotrauma', 'TM018', 'PA123', 'DR192', 'NU132')
/
insert into chart values('CH531', 'blunt trauma', 'TM213', 'PA456', 'DR102', 'NU152')
/
insert into chart values('CH887', 'bleeding cramp', 'TM856', 'PA789', 'DR744', 'NU856')
/
insert into chart values('CH313', 'brusting fracture', 'TM991', 'PA012', 'DR264', 'NU301')
/