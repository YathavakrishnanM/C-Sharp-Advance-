using System;
using System.Collections.Generic;
using System.Collections;

namespace QueueDS
{
    public class CustomQueue<Type>:IEnumerable,IEnumerator
    {
        private  int _head;

        private int _tail;

        private int _count;

        private int _capacity;

        private Type[] _arrry;

        public int Count{get{return _count;}}


        public CustomQueue(){
            _head=0;
            _tail=0;
            _count=0;
            _capacity=4;
            _arrry=new Type[_capacity];
        }

        public CustomQueue(int size){
            _head = 0;
            _tail = 0;
            _count = 0;
            _capacity = size;
            _arrry = new Type[_capacity];
        }

        public void Enqueue(Type element){

            if(_count==_capacity){
                GrowSize();
            }
            _arrry[_tail]=element;
            _tail++;
            _count++;

        }

        void GrowSize(){
            _capacity=_capacity*2;

            Type [] temp=new Type[_capacity];

            for(int i=0;i<_tail;i++){
                temp[i]=_arrry[i];
            }
            _arrry=temp;


        }

        public Type Peek(){

            if(_tail==_head){
                return default(Type);
            }else{
                return _arrry[_head];
            }
        }

        public Type DeQueue(){
            if(_head==_tail){
                return default(Type);
            }else{
                _head++;
                _count--;
                return _arrry[_head-1];
            }
        }

        int position;
        public IEnumerator GetEnumerator(){
            position=_head-1;
            return (IEnumerator) this;
        }

        public bool MoveNext(){
            if(position<_tail-1){
                position++;
                return true;
            }
            Reset();
            return false;
        }

        public void Reset(){
            position=_head-1;
        }

        public object Current{get{return _arrry[position];}}


    }
}