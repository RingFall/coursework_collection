#include<iostream>
#include<cstdio>
#include<cstring>
#include<string>
#include<algorithm>
#include<vector>
#include<set>
#include<cmath>
#include<map>
#include<fstream>
using namespace std;
char M[1005],C[1005],K[1005];
char flag;
struct Node{
    float value; //�غ�ָ����,�����ǵı�׼�غ�ָ���Ĳ�ֵԽСԽ��
    int length;
};
vector< Node > key; //���key���ܵĳ��Ⱥ��غ�ָ����
set< int > key_len; //���key���ܵĳ���
/*
Ӣ����ĸʹ��Ƶ�ʱ� g
*/
double g[]={0.08167, 0.01492, 0.02782, 0.04253, 0.12702, 0.02228, 0.02015, 0.06094, 0.06966, 0.00153, 0.00772, 0.04025,0.02406, 0.06749, 0.07507, 0.01929, 0.00095, 0.05987, 0.06327, 0.09056, 0.02758, 0.00978, 0.02360, 0.00150,0.01974, 0.00074};
bool Greater_sort(Node a,Node b){
    return a.value<b.value;
}
/*
Coincidence_index,������ѡ������غ�ָ��
start��ʾ��������,length��ʾ����
�غ�ָ��CI��ʵ�ʹ���ֵ��
X(i)=F(i)*(F(i)-1)/sum*(sum-1)
('a'<=i<='z',F(i)Ϊi�ַ��ڵ�ǰ������ֵĴ���)
������X(i)��;�������������غ�ָ��CI
*/
float Coincidence_index(string cipher,int start,int length){
    float index=0.000;
    int sum=0;
    int num[26];
    memset(num,0,sizeof(num));
    while(start<=cipher.length()){
        num[cipher[start]-'a']++;
        start+=length;
        sum++;
    }
    for(int i=0;i<26;i++){
        if(num[i]<=1) continue;
        index+=(float)(num[i]*(num[i]-1))/(float)((sum)*(sum-1));
    }
    return index;
}
/*
Find_same()�������Ǹ��� kasiski���Է���ԭ��
���ǿ��Ի�ȡkey���ܵĳ���
*/
void Find_same(string cipher){
    for(int i=3;i<5;i++){
        for(int j=0;j<cipher.length()-i;j++){
            string p=cipher.substr(j,i);
            for(int k=j+i;k<cipher.length()-i;k++){
                string tmp=cipher.substr(k,i);
                if(tmp==p){
                    Node x;
                    x.length=k-j;
                    key.push_back(x);
                }
            }
        }
    }
}
int gcd(int a,int b){
    if(b==0) return a;
    else return gcd(b,a%b);
}
/*

������ܵ�key��ֵ���������
�����غ�ָ������,��key�ĳ��Ƚ�������

*/
void Get_key(string cipher){
    Find_same(cipher);
    for(int i=0;i<key.size();i++){
        int x=key[i].length;
        for(int j=0;j<key.size();j++){
            if(key[i].length>key[j].length)
                key_len.insert(gcd(key[i].length,key[j].length));
            else
                key_len.insert(gcd(key[j].length,key[i].length));
        }
    }
    key.clear();
    set< int >::iterator it=key_len.begin();
    while(it!=key_len.end()){
        int length=*it;
        if(length==1){
            it++;
            continue;
        }
        float sum=0.000;
        cout<<length<<" ";
        for(int i=0;i<length;i++){
            cout<<Coincidence_index(cipher,i,length)<<"  ";
            sum+=Coincidence_index(cipher,i,length);
        }
        cout<<endl;
        Node x;
        x.length=length;
        x.value=(float)fabsf(0.065-(float)(sum/(float)length));
        if(x.value<=0.1)
            key.push_back(x);
        it++;
    }
    sort(key.begin(),key.end(),Greater_sort);
}
/*

Ϊ����߽��ܵĳɹ���,����ȡǰ��10�������ӽ������
��ÿ�������ӵ�ÿ�����ӽ�����ĸ�����غ�ָ������
��Chi����(��������),��ȡ��ֵ��
�÷�ֵ�㼫�п���������
*/
void Get_ans(string cipher){
    int lss=0;
    ofstream myout("temp.txt");
    while(lss<key.size()&&lss<10)
	{
        Node x=key[lss];
        int ans[cipher.length()];
        memset(ans,0,sizeof(ans));
        map< char ,int > mp;
        for(int i=0;i<x.length;i++){
            double max_pg=0.000;
            for(int k=0;k<26;k++){
                mp.clear();
                double pg=0.000;
                int sum=0;
                for(int j=i;j<cipher.length();j+=x.length){
                    char c=(char)((cipher[j]-'a'+k)%26+'a');
                    mp[c]++;
                    sum++;
                }
                for(char j='a';j<='z';j++){
                    pg+=((double)mp[j]/(double)sum)*g[j-'a'];
                }
                if(pg>max_pg){
                    ans[i]=k;
                    max_pg=pg;
                }
            }
        }
        if(flag=='c')
        {
	        cout<<endl<<"key_length: "<<x.length<<endl<<"key is: ";
	        for(int i=0;i<x.length;i++){
	            cout<<(char)((26-ans[i])%26+'a')<<" ";
	        }
	        cout<<endl<<"Clear text:"<<endl;
	        for(int i=0;i<cipher.length();i++){
	            cout<<(char)((cipher[i]-'a'+ans[i%x.length])%26+'a');
	        }
	        cout<<endl;
	    }
	    else
	    {
	    	myout<<endl<<"key_length: "<<x.length<<endl<<"key is: ";
	        for(int i=0;i<x.length;i++){
	            myout<<(char)((26-ans[i])%26+'a')<<" ";
	        }
	        myout<<endl<<"Clear text:"<<endl;
	        for(int i=0;i<cipher.length();i++){
	            myout<<(char)((cipher[i]-'a'+ans[i%x.length])%26+'a');
	        }
	        myout<<endl;
	    }
        lss++;
    }
    myout.close();
}


int main()
{
	cout<<"Vigen��re ����\nģʽѡ�� 1.���� 2.���� 3.�ƽ�\n�ƽ����ѡ�� c.����̨ f.�ļ�\n";
	int mode;
	while(cin>>mode)
	{
		if(mode==1)
		{
			cout<<"����M��";
			cin>>M;
			cout<<"��ԿK��";
			cin>>K;
		    int k=0;
		    int lenk=strlen(K);
		    int lenm=strlen(M);
		    for(int i=0;i<lenk;i++)
		        if(K[i]>='A'&&K[i]<='Z')
		            K[i]+=32;
		    for(int m=0;m<lenm;m++)
			{
		        if(M[m]<'a')
		            C[m]=((M[m]-'A'+26)+(K[k]-'a'))%26+'A';
		        else
		            C[m]=((M[m]-'a'+26)+(K[k]-'a'))%26+'a';
		        k++;
	        	if(k==lenk) 
	            	k=0;
		    }
		    cout<<"����C��"<<C<<endl; 
		}
		else if(mode==2)
		{
			cout<<"��ԿK��";
			cin>>K;
			cout<<"����C��";
			cin>>C;
		    int k=0;
		    int lenk=strlen(K);
		    int lenc=strlen(C);
		    for(int i=0;i<lenk;i++)
		        if(K[i]>='A'&&K[i]<='Z')
		            K[i]+=32;
		    for(int c=0;c<lenc;c++)
			{
		        if(C[c]<'a')
		            M[c]=((C[c]-'A'+26)-(K[k]-'a'))%26+'A';
		        else
		            M[c]=((C[c]-'a'+26)-(K[k]-'a'))%26+'a';
		        k++;
	        	if(k==lenk) 
	            	k=0;
		    }
		    cout<<"����M��"<<M<<endl;  
		}
		else if(mode==3)
		{
			cin>>flag; 
			cout<<"����C��"; 
			string cipher;
		    cin>>cipher;
		    transform(cipher.begin(), cipher.end(), cipher.begin(),::tolower);
		    Get_key(cipher);
		    for(int i=0;i<key.size();i++){
		        cout<<key[i].length<<"  and "<<key[i].value<<endl;
		    }
		    Get_ans(cipher);
		}
	}
    return 0;
}
