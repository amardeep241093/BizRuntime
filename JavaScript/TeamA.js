function Student(name, id)
{
    this.name = name;
    this.id = id;
    this.getStudentData = function()
    {
        return this.name + " " + this.id;
    }

}